import { useState, useEffect } from "react";
import { Product } from "../../app/models/products"
import ProductList from "./ProductList";

export default function Catalog() {
    const [products, setProducts] = useState<Product[]>([]);
  
    //gets the products from the api
    useEffect(() => { 
      fetch('http://localhost:5195/api/products')
      .then(response => response.json())
      .then(data => setProducts(data))
    }, [])
  
    return (
        <>
            <ProductList products={products} />
        </>
    )
}