namespace AgendaSIG5.App.Dominio
{
    public class Agenda
    {
        public int Id { get; set; }
        public int FK_Id_Sede { get; set; }
        public int FK_Id_Paciente { get; set; }
        public int FK_Id_Medico { get; set; }
        public string FechaCita { get; set; }
        public string HoraCita { get; set; }
        public string Notas { get; set; }
    }
}