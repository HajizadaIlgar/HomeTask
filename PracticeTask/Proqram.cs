using PracticeTask;

class Proqram
{
    static void Main(string[] args)
    {

        Appointment appointment0 = new Appointment
        {
            StartTime = DateTime.Parse("12:00"),
            EndTime = DateTime.Parse("13:45"),
            No = 1,
            Doctor = new Doctor { DoctorName = "Receb", DoctorSurname = "Eliyev", DoctorAge = 28 }
        };
        Appointment appointment1 = new Appointment
        {
            StartTime = DateTime.Parse("12:00"),
            EndTime = DateTime.Parse("13:45"),
            No = 1,
            Patient = new Patient { PatientName = "Receb", PatientSurname = "Eliyev", PatientAge = 28 }
        };
        Appointment appointment2 = new Appointment
        {
            StartTime = DateTime.Parse("8:00"),
            EndTime = DateTime.Parse("10:00"),
            No = 2,
            Patient = new Patient { PatientName = "Veli", PatientSurname = "KJH", PatientAge = 3 }
        };
        Appointment appointment3 = new Appointment
        {
            StartTime = DateTime.Parse("14:00"),
            EndTime = DateTime.Parse("16:45"),
            No = 3,
            Patient = new Patient { PatientName = "Revan", PatientSurname = "hjgjgh", PatientAge = 18 }
        };
        Hospital.AddAppointment(appointment1);
        Hospital.AddAppointment(appointment2);
        Hospital.AddAppointment(appointment3);

        foreach (var item in Hospital.appointments)
        {
            Console.WriteLine(item.Patient.PatientName + " " + item.EndTime);
        }

        Hospital.EndAppointment(2);

        foreach (var item in Hospital.appointments)
        {
            Console.WriteLine(item.Patient.PatientName + " " + item.EndTime);
        }
        Console.WriteLine(Hospital.GetAppointment(3).Patient.PatientName);
        Console.WriteLine("------------------------------------------------------------");



        Hospital.GetAllAppointments();
        foreach (var item in Hospital.appointments)
        {
        }


    }
    static void PrintInfo()
    {
        Console.WriteLine("""
            1.Appointment yarat
            2. Appointment-i bitir
            3. Bütün appointment-lere bax
            4. Bu hefteki appointment-lərə bax
            5. Bugünki appointment-lere bax
            6. Bitmemiş appointmentlere bax
            7. Menudan çıx
            """);
    }

}
/*
Appointment class
 -No
 - Patient
 - Doctor
 - StartDate
 - EndDate

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


proqram run olunduqda console-da aşağıdakı menu göstərilir:
1.Appointment yarat
2. Appointment-i bitir
3. Bütün appointment-lərə bax
4. Bu həftəki appointment-lərə bax
5. Bugünki appointment-lərə bax
6. Bitməmiş appointmentlərə bax
7. Menudan çıx
    */