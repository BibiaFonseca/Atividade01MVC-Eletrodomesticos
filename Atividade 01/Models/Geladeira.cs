namespace Atividade_01.Models
{
    public class Geladeira : Eletrodomestico
    {
        public int CapacidadeLitros { get; set; }
        public bool TemFreezer { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Consumo Energético: {ConsumoEnergetico}, Capacidade de Litros: {CapacidadeLitros}, Tem Freezer: {(TemFreezer ? "Sim" : "Não")}";
        }
    }
}
