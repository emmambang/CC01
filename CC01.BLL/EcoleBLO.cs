using System;
using CC01.BO;
using CC01.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CC01.DAL
{
    public class EcoleBLO
    {
        private EcoleDAO ecoleRepo;
        private string dbFolder;
        public EcoleBLO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            ecoleRepo = new EcoleDAO(dbFolder);
        }

        public void DeleteEcole(Ecole ecole)
        {
        }
        public void CreateEcole(Ecole oldEcole, Ecole newEcole)
        {
            string filename = null;
            if (!string.IsNullOrEmpty(newEcole.Logo.ToString()))
            {
                string ext = Path.GetExtension(newEcole.Logo.ToString());
                filename = Guid.NewGuid().ToString() + ext;
                FileInfo fileSource = new FileInfo(newEcole.Logo.ToString());
                string filePath = Path.Combine(dbFolder, "logo", filename);
                FileInfo fileDest = new FileInfo(filePath);
                if (!fileDest.Directory.Exists)
                    fileDest.Directory.Create();
                fileSource.CopyTo(fileDest.FullName);
            }
            newEcole.Logo =new byte[] { byte.Parse(filename) };
            //ecoleRepo.Add(newEcole);

            if (!string.IsNullOrEmpty(oldEcole.Logo.ToString()))
                File.Delete(oldEcole.Logo.ToString());
        }

        public Ecole GetEcole()
        {
            Ecole ecole = ecoleRepo.Get();
            if (ecole != null)
                if (!string.IsNullOrEmpty(ecole.Logo.ToString()))
                    ecole.Logo = new byte[] { Byte.Parse(Path.Combine(dbFolder, "logo", ecole.Logo.ToString())) };
            return ecole;
        }
    }
}
