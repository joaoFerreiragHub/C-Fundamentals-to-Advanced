// ? - significa que a propriedade é opcional
// export interface Pessoa {
export type Pessoa = {
    id?: number,
    nome: string,
    localidade: string,
    casado: boolean
}