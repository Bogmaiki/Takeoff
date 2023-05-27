export interface Product {
    id: number;
    name: string;
    description: string;
    price: number;
    pictureUrl: string;
    sizes: Size[];
    collection: string;
    quantityInStock: number;
    releaseDate: string; 
    condition: string;
    style: string;
  }
  
  export interface Size {
    id: number;
    value: number;
  }
  