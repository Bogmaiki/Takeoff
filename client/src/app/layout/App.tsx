import { useEffect, useState } from "react";
import { Product } from "../models/products";
import Catalog from "../../features/catalog/Catalog";
import Header from "./Header";
import { Container, CssBaseline } from "@mui/material";

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
      <CssBaseline />
      <Header />
      <Container>
        <Catalog products={products}/>
      </Container>
    </>
  );
}

export default App;
