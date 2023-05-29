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
  size: string;
  collection: string;
  quantityInStock: number;
  releaseDate: string; 
  condition: string;
  style: string;
}