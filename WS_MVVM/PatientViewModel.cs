using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS_MVVM
{
    public class PatientViewModel:ObservableObject
    {
        public PatientViewModel()
        {
            Patients = new ObservableCollection<Patient>();
            Init();
        }

        public PatientViewModel Init() /*Normalerweise hier DBContext mitgeben*/
        {
            Patients.Add(new Patient { PatientID = 1,Firstname="Sepp",Lastname="Hubert",Birthday=DateTime.Now.AddYears(-20),IsMale = true});
            Patients.Add(new Patient { PatientID = 2, Firstname = "Depp", Lastname = "Hubert1", Birthday = DateTime.Now.AddYears(-25), IsMale = true });
            Patients.Add(new Patient { PatientID = 3, Firstname = "Dreck", Lastname = "Hubert2", Birthday = DateTime.Now.AddYears(-30), IsMale = true });
            Patients.Add(new Patient { PatientID = 4, Firstname = "Nega", Lastname = "Hubert3", Birthday = DateTime.Now.AddYears(-35), IsMale = true });
            Patients.Add(new Patient { PatientID = 5, Firstname = "NegaWeib", Lastname = "Hubert4", Birthday = DateTime.Now.AddYears(-40), IsMale = false });
            return this;
        }

		private ObservableCollection<Patient> patients;

		public ObservableCollection<Patient> Patients
		{
			get { return patients; }
            set { patients = value;
                RaisePropertyChangedEvent(nameof(Patients));
            }
		}

        private Patient selectedPatient;
        public Patient SelectedPatient
        { 
            get { return selectedPatient; }
            set { selectedPatient = value;
                RaisePropertyChangedEvent(nameof(selectedPatient));
            }
        }
    }
}
