export enum CodigoOperacao {
    Soma = 1,
    Subtracao,
    Multiplicacao,
    Divisao
}

export const DescricaoCodigoOperacao = new Map<number, string>([
    [CodigoOperacao.Soma, 'Soma'],
    [CodigoOperacao.Subtracao, 'Subtração'],
    [CodigoOperacao.Multiplicacao, 'Multiplicação'],
    [CodigoOperacao.Divisao, 'Divisão'],
]);
