export type Utilizadores = {
  id?: number;
  nome: string;
  email: string;
  senha: string;
  morada: string;
  codigoPostal: number;
  pais: string;
  wishlist?: Array<number>;
};
