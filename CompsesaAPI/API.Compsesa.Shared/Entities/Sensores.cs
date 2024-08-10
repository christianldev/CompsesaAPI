using System;

namespace API.Compsesa.Shared.Entities;

public class Sensores
{
    public int Id { get; set; }
    public int Codigo_Parametro { get; set; }
    public string Descripcion_Larga { get; set; }
    public string Descripcion_Med { get; set; }
    public string Descripcion_Corta { get; set; }
    public string Abreviacion { get; set; }
    public string Observacione { get; set; }
    public DateTime Fecha_Creacion { get; set; }
    public DateTime Fecha_Modificacion { get; set; }
    public string Estado { get; set; }
    public string Unidad { get; set; }
}
