namespace Atividade_01.Models
{
    public class Televisor : Eletrodomestico
    {
        public int TamanhoTela { get; set; }
        public bool EhSmart { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Consumo Energético: {ConsumoEnergetico}, Tamanho da Tela: {TamanhoTela}, É smart:{(EhSmart ? "Sim" : "Não")}";
        }
    }
}
