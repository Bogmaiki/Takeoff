import { useState, useEffect } from "react";
import { Product } from "../../app/models/products"
import ProductList from "./ProductList";
import agent from "../../app/api/agent";

export default function Catalog() {
    const [products, setProducts] = useState<Product[]>([]);
  
    //gets the products from the api
    useEffect(() => { 
        agent.Catalog.list().then(products => setProducts(products))
    }, [])
  
    return (
        <>
            <ProductList products={products} />
        </>
    )
}