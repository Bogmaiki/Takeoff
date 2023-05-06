import { useEffect, useState } from "react";
import { Product } from "../models/products";
import Catalog from "../../features/catalog/Catalog";
import { Typography } from "@mui/material";

function App() {
  //
  const [products, setProducts] = useState<Product[]>([]);
  
  //gets the products from the api
  useEffect(() => { 
    fetch('http://localhost:5195/api/products')
    .then(response => response.json())
    .then(data => setProducts(data))
  }, [])

  return (
    <>
      <Typography variant="h1">Takeoff</Typography>
      <Catalog products={products}/>
    </>
  );
}

export default App;
