export type Produtos = {
  id?: number;
  nome: string;
  marca: string;
  tipo_de_produto: string;
  menuHomemid?: number;
  opcoes: string;
  cor: string;
  preco: number;
  descricao: string;
  foto_principal?: string;
  foto_secundaria?: string;
  destaques: boolean;
};
