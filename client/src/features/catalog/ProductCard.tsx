import { Avatar, Card, CardActionArea, CardContent, CardHeader, CardMedia, Typography } from "@mui/material";
import { Product } from "../../app/models/products";
import { currencyFormat } from "../../app/util/util";
import { Link } from "react-router-dom";

interface Props {
  product: Product;
}

export default function ProductCard({ product }: Props) {
  return (
    <Card>
      <CardActionArea component={Link} to={`/catalog/${product.id}`}>
        <CardHeader
          avatar={
            <Avatar sx={{ bgcolor: 'secondary.main' }}>
              {product.name.charAt(0).toUpperCase()}
            </Avatar>
          }
          title={product.name}
          titleTypographyProps={{
            sx: { fontWeight: 'bold', color: 'primary.main' },
          }}
        />
        <CardMedia
          sx={{ height: 140, width: '100%', backgroundSize: 'cover', bgcolor: 'primary.light' }}
          image={product.pictureUrl}
          title={product.name}
        />
        <CardContent>
          <Typography gutterBottom color="secondary" variant="h5">
            {currencyFormat(product.price)}
          </Typography>
          <Typography variant="body2" color="text.secondary">
            {product.collection}
          </Typography>
        </CardContent>
      </CardActionArea>
    </Card>
  );
}
