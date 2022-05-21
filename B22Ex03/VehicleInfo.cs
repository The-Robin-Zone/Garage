using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public enum e_StatusVehicle
    {
        InRepair,
        Repaired,
        PayedFor
    }

    public class VehicleInfo
    {
        private string m_OwnerName;
        private string m_OwnerPhoneNumber;
        private e_StatusVehicle m_StatusVehicule;

        public VehicleInfo()
        {
            this.m_StatusVehicule = e_StatusVehicle.InRepair;
        }

        public string OwnerName
        {
            get
            {
                return this.m_OwnerName;
            }
            set
            {
                this.m_OwnerName = value;
            }
        }

        public string OwnerPhoneNumber
        {
            get
            {
                return this.m_OwnerPhoneNumber;
            }
            set
            {
                this.m_OwnerPhoneNumber = value;
            }
        }

        public e_StatusVehicle StatusVehicule
        {
            get
            {
                return this.m_StatusVehicule;
            }
            set
            {
                this.m_StatusVehicule = value;
            }
        }

        // Change the status of the vehicule
        public e_StatusVehicle UpdateStatusVehicule(int i_Status)
        {
            e_StatusVehicle statusVehicule = e_StatusVehicle.InRepair;
            try
            {
                if (i_Status == 0)
                {
                    statusVehicule = e_StatusVehicle.InRepair;
                }
                else if (i_Status == 1)
                {
                    statusVehicule = e_StatusVehicle.Repaired;
                }
                else if (i_Status == 2)
                {
                    statusVehicule = e_StatusVehicle.PayedFor;
                }
                else
                {
                    throw new ArgumentException(string.Format("The status entered is not a legal one"));
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return statusVehicule;
        }

        // Return the string contain into the enum
        public string StatusVehiculeToString()
        {
            string o_StatusVehiculeToString = string.Empty;
            if (this.m_StatusVehicule == e_StatusVehicle.InRepair)
            {
                o_StatusVehiculeToString = "In Repair";
            }
            else if (this.m_StatusVehicule == e_StatusVehicle.Repaired)
            {
                o_StatusVehiculeToString = "Repaired";
            }
            else if (this.m_StatusVehicule == e_StatusVehicle.PayedFor)
            {
                o_StatusVehiculeToString = "Payed for";
            }
            return o_StatusVehiculeToString;
        }

        public override string ToString()
        {
            string o_VehicleStatusDetails = string.Format("Vehicle info:\nOwner Name: {0}, Owner phone number: {1}, Vehicle Status: {2}",
                m_OwnerName, m_OwnerPhoneNumber, StatusVehiculeToString());

            return o_VehicleStatusDetails;
        }
    }
}
