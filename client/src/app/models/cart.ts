export interface Cart {
  id: number;
  buyerId: string;
  items: CartItem[];
}

export interface CartItem {
  productId: number;
  name: string;
  price: number;
  pictureUrl: string;
  quantity: number;
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