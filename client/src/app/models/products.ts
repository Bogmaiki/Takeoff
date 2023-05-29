export interface Product {
    id: number;
    name: string;
    description: string;
    price: number;
    pictureUrl: string;
    size: string;
    collection: string;
    quantityInStock: number;
    releaseDate: string; 
    condition: string;
    style: string;
  }
  
export interface ProductParams {
  orderBy: string;
  searchTerm?: string;
  collections?: string[];
  sizes?: string[];
  pageNumber: number;
  pageSize: number;
}