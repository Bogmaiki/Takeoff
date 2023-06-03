import { Grid, Typography } from '@mui/material';
import CartSummary from '../Cart/CartSummary';
import CartTable from '../Cart/CartTable';
import { useAppSelector } from '../../app/store/configureStore';

export default function Review() {
  const { cart } = useAppSelector(state => state.cart);

  return (
    <>
      <Typography variant="h6" gutterBottom>
        Order summary
      </Typography>
      {cart &&
      <CartTable items={cart.items} isCart={false}/>}
      <Grid container>
        <Grid item xs={6} />
        <Grid item xs={6}>
          <CartSummary />
        </Grid>
      </Grid>
    </>
  );
}