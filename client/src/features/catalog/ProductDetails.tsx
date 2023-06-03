import { Divider, Grid, Table, TableBody, TableCell, TableContainer, TableRow, TextField, Typography } from "@mui/material";
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import NotFound from "../../app/errors/NotFound";
import LoadingComponent from "../../app/layout/LoadingComponent";
import { useAppDispatch, useAppSelector } from "../../app/store/configureStore";
import { addCartItemAsync, removeCartItemAsync } from "../Cart/cartSlice";
import { fetchProductAsync, productSelectors } from "./catalogSlice";
import { LoadingButton } from "@mui/lab";

export default function ProductDetails() {
  const { cart, status } = useAppSelector((state) => state.cart);
  const dispatch = useAppDispatch();
  const { id } = useParams<{ id: string }>();
  const product = useAppSelector((state) => productSelectors.selectById(state, id!));
  const { status: productStatus } = useAppSelector((state) => state.catalog);
  const [quantity, setQuantity] = useState(0);
  const item = cart?.items.find((i) => i.productId === product?.id);

  useEffect(() => {
    if (item) setQuantity(item.quantity);
    if (!product && id) dispatch(fetchProductAsync(parseInt(id)));
  }, [id, item, dispatch, product]);

  function handleInputChange(event: React.ChangeEvent<HTMLInputElement>) {
    const newQuantity = parseInt(event.target.value);
    if (newQuantity >= 0) {
      setQuantity(newQuantity);
    }
  }

  function handleUpdateCart() {
    if (!item || quantity > item.quantity) {
      const updatedQuantity = item ? quantity - item.quantity : Number(quantity);
      dispatch(
        addCartItemAsync({
          productId: product?.id!,
          quantity: updatedQuantity,
        })
      );
    } else {
      const updatedQuantity = item.quantity - quantity;
      dispatch(
        removeCartItemAsync({
          productId: product?.id!,
          quantity: updatedQuantity,
        })
      );
    }
  }

  if (productStatus.includes("pending")) return <LoadingComponent message="Loading product..." />;

  if (!product) return <NotFound />;

  return (
    <Grid container spacing={6}>
      <Grid item xs={12} sm={6}>
        <img src={product.pictureUrl} alt={product.name} style={{ width: "100%" }} />
      </Grid>
      <Grid item xs={12} sm={6}>
        <Typography variant="h4" gutterBottom>
          {product.name}
        </Typography>
        <Typography variant="h5" color="secondary">
          ₪{(product.price / 100).toFixed(2)}
        </Typography>
        <Divider sx={{ mb: 2 }} />
        <TableContainer>
          <Table>
            <TableBody>
              <TableRow>
                <TableCell>Condition</TableCell>
                <TableCell>{product.condition}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Style</TableCell>
                <TableCell>{product.style}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Release Date</TableCell>
                <TableCell>{new Date(product.releaseDate).toLocaleDateString("en-GB")}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Description</TableCell>
                <TableCell>{product.description}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Size</TableCell>
                <TableCell>{product.size}</TableCell>
              </TableRow>
            </TableBody>
          </Table>
        </TableContainer>
        <Grid container spacing={2}>
          <Grid item xs={6}>
            <TextField
              onChange={handleInputChange}
              variant="outlined"
              type="number"
              label="Quantity in Cart"
              fullWidth
              value={quantity}
            />
          </Grid>
          <Grid item xs={6}>
            <LoadingButton
              disabled={item?.quantity === quantity || quantity === 0}
              loading={status.includes("pending")}
              onClick={handleUpdateCart}
              sx={{ height: "55px" }}
              color="primary"
              size="large"
              variant="contained"
              fullWidth
            >
              {item ? "Update Quantity" : "Add to Cart"}
            </LoadingButton>
          </Grid>
        </Grid>
      </Grid>
    </Grid>
  );
}
