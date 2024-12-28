namespace PracticeTask;

class Hospital
{
    public static List<Appointment> appointments = new List<Appointment>();
    public static void AddAppointment(Appointment
    newappointment)
    {
        appointments.Add(newappointment);
    }
    public static void EndAppointment(int no)
    {
        Appointment appo = appointments.Find(x => x.No == no);
        if (appo != null)
        {
            appo.EndTime = DateTime.Now;
        }
    }
    public static Appointment GetAppointment(int no)
    {
        Appointment app = appointments.Find(x => x.No == no);
        return app;

    }

    public static List<Appointment> GetAllAppointments()
    {
        return appointments;
    }
    public static List<Appointment> GetWeeklyAppointments(DateTime endTime)
    {
        for (int i = 0; i < appointments.Count; i++)
        {

        }
    }
    public static void GetTodaysAppointments()
    {

    }
    public static void GetAllContinuingAppointments()
    {

    }
}
/*
Hospital class
-Appointments
- AddAppointment()
- EndAppointment() - no deyeri gelir ve hemin appointmentin
                     enddate-ini qeyd edir
- GetAppointment() - no deyeri qebul ve hemin appointmenti
                     return edir
- GetAllAppointments()
- GetWeeklyAppointments()
- GetTodaysAppointments()
- GetAllContinuingAppointments()

 */