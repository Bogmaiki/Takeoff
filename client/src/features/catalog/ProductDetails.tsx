import { Divider, Grid, Stack, Table, TableBody, TableCell, TableContainer, TableRow, TextField, ToggleButton, ToggleButtonGroup, Typography } from "@mui/material";
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import NotFound from "../../app/errors/NotFound";
import LoadingComponent from "../../app/layout/LoadingComponent";
import { LoadingButton } from "@material-ui/lab";
import { useAppDispatch, useAppSelector } from "../../app/store/configureStore";
import { addCartItemAsync, removeCartItemAsync } from "../Cart/cartSlice";
import { fetchProductAsync, productSelectors } from "./catalogSlice";

export default function ProductDetails() {
  const { cart, status } = useAppSelector(state => state.cart);
  const dispatch = useAppDispatch();
  const { id } = useParams<{ id: string }>();
  const product = useAppSelector(state => productSelectors.selectById(state, id!));
  const { status: productStatus } = useAppSelector(state => state.catalog);
  const [quantity, setQuantity] = useState(0);
  const item = cart?.items.find(i => i.productId === product?.id);
  const [size, setSize] = useState<string | null>(null);
  

  const handleSizeSelection = (
    event: React.MouseEvent<HTMLElement>,
    newSize: string | null,
  ) => {
    if (newSize !== null) {
      setSize(newSize);
    }
  };

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
      dispatch(addCartItemAsync({ productId: product?.id!, quantity: updatedQuantity, size: size !== null ? Number(size) : undefined }))
    } else {
      const updatedQuantity = item.quantity - quantity;
      dispatch(removeCartItemAsync({ productId: product?.id!, quantity: updatedQuantity, size: product?.sizes[0]?.id }))
    }
  }

  if (productStatus.includes('pending')) return <LoadingComponent message="Loading product..." />;

  if (!product) return <NotFound />;

  const isAddToCartDisabled = size === null || size === '';

  return (
    <Grid container spacing={6}>
      <Grid item xs={12} sm={6}>
        <img src={product.pictureUrl} alt={product.name} style={{ width: "100%" }} />
      </Grid>
      <Grid item xs={12} sm={6}>
        <Typography variant="h4" gutterBottom>{product.name}</Typography>
        <Typography variant="h5" color="secondary">₪{(product.price / 100).toFixed(2)}</Typography>
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
                <TableCell>{new Date(product.releaseDate).toLocaleDateString('en-GB')}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Description</TableCell>
                <TableCell>{product.description}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Sizes</TableCell>
                <TableCell>
                  <Stack direction="row" spacing={4}>
                    <ToggleButtonGroup
                      value={size}
                      exclusive
                      onChange={handleSizeSelection}
                      aria-label="size selection"
                    >
                      {product.sizes &&
                        product.sizes.map((size) => (
                          <ToggleButton key={size.id} value={size.id}>
                            {size.value}
                          </ToggleButton>
                        ))}
                    </ToggleButtonGroup>
                  </Stack>
                </TableCell>
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
              disabled={isAddToCartDisabled || (item?.quantity === quantity)}
              loading={status.includes('pending')}
              onClick={handleUpdateCart}
              sx={{ height: '55px' }}
              color="primary"
              size="large"
              variant="contained"
              fullWidth
            >
              {item ? 'Update Quantity' : 'Add to Cart'}
            </LoadingButton>
          </Grid>
        </Grid>
      </Grid>
    </Grid>
  );
}
