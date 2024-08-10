using System;

namespace API.Compsesa.Shared.Entities;

public class DatosSensores
{
    public int Id { get; set; }
    public int Codigo_Parametro { get; set; }
    public string Parametro_Sensores_Id { get; set; }
    public string Nombre_Parametro { get; set; }
    public DateTime Fecha_Dato { get; set; }
    public decimal Valor_Numero { get; set; }
}
