using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;
using System.Windows.Forms;

namespace PhyloMain
{
    class AppSettings
    {
        private bool appSettingsChanged;
        public string progsdir;
        public bool hideparam;
        public bool hidecalc;
        public string bioedit;
        public string clustalw;
        public string mafft;
        public string gblocks;
        public string raxml;
        public string threads;
        public string perl;
        public string bayes;
        public string iqtree;
        public string figtree;
        public string paupup;
        public string imagemagick;
        public string readseq;
        public string sate;
        public string similarity;
        public string muscle;
        public string fasttree;
        public string sequencematrix;

        public string ProgsDir
        {
            get { return progsdir; }
            set
            {
                if(value != progsdir)
                {
                    progsdir = value;
                    appSettingsChanged = true;
                }
            }
        }
        public bool HideParam
        {
            get { return hideparam; }
            set
            {
                if (value != hideparam)
                {
                    hideparam = value;
                    appSettingsChanged = true;
                }
            }
        }
        public bool HideCalc
        {
            get { return hidecalc; }
            set
            {
                if (value != hidecalc)
                {
                    hidecalc = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string BioEdit
        {
            get { return bioedit; }
            set
            {
                if (value != bioedit)
                {
                    bioedit = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string ClustalW
        {
            get { return clustalw; }
            set
            {
                if (value != clustalw)
                {
                    clustalw = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string Mafft
        {
            get { return mafft; }
            set
            {
                if (value != mafft)
                {
                    mafft = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string Gblocks
        {
            get { return gblocks; }
            set
            {
                if (value != gblocks)
                {
                    gblocks = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string Raxml
        {
            get { return raxml; }
            set
            {
                if (value != raxml)
                {
                    raxml = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string Threads
        {
            get { return threads; }
            set
            {
                if (value != threads)
                {
                    threads = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string Perl
        {
            get { return perl; }
            set
            {
                if (value != perl)
                {
                    perl = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string Bayes
        {
            get { return bayes; }
            set
            {
                if (value != bayes)
                {
                    bayes = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string IQtree
        {
            get { return iqtree; }
            set
            {
                if (value != iqtree)
                {
                    iqtree = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string Figtree
        {
            get { return figtree; }
            set
            {
                if (value != figtree)
                {
                    figtree = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string Paupup
        {
            get { return paupup; }
            set
            {
                if (value != paupup)
                {
                    paupup = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string Imagemagick
        {
            get { return imagemagick; }
            set
            {
                if (value != imagemagick)
                {
                    imagemagick = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string Readseq
        {
            get { return readseq; }
            set
            {
                if (value != readseq)
                {
                    readseq = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string Sate
        {
            get { return sate; }
            set
            {
                if (value != sate)
                {
                    sate = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string Similarity
        {
            get { return similarity; }
            set
            {
                if (value != similarity)
                {
                    similarity = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string Muscle
        {
            get { return muscle; }
            set
            {
                if (value != muscle)
                {
                    muscle = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string Fasttree
        {
            get { return fasttree; }
            set
            {
                if (value != fasttree)
                {
                    fasttree = value;
                    appSettingsChanged = true;
                }
            }
        }
        public string SequenceMatrix
        {
            get { return sequencematrix; }
            set
            {
                if (value != sequencematrix)
                {
                    sequencematrix = value;
                    appSettingsChanged = true;
                }
            }
        }
        public bool SaveAppSettings()
        {
            if (this.appSettingsChanged)
            {
                StreamWriter myWriter = null;
                XmlSerializer mySerializer = null;
                try
                {
                    mySerializer = new XmlSerializer(typeof(AppSettings));
                    myWriter = new StreamWriter(Application.LocalUserAppDataPath + @"\PhyloMain.config", false);
                    mySerializer.Serialize(myWriter, this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (myWriter != null)
                    {
                        myWriter.Close();
                    }
                }
            }
            return appSettingsChanged;
        }
        public bool LoadAppSettings()
        {
            XmlSerializer mySerializer = null;
            FileStream myFileStream = null;
            bool fileExists = false;
            try
            {
                mySerializer = new XmlSerializer(typeof(AppSettings));
                FileInfo fi = new FileInfo(Application.LocalUserAppDataPath + @"\myApplication.config");
                if (fi.Exists)
                {
                    myFileStream = fi.OpenRead();
                    AppSettings myAppSettings =
                      (AppSettings)mySerializer.Deserialize(myFileStream);
                    this.progsdir = myAppSettings.progsdir;
                    this.hideparam = myAppSettings.hideparam;
                    this.hidecalc = myAppSettings.hidecalc;
                    this.bioedit = myAppSettings.bioedit;
                    this.clustalw = myAppSettings.clustalw;
                    this.mafft = myAppSettings.mafft;
                    this.gblocks = myAppSettings.gblocks;
                    this.raxml = myAppSettings.raxml;
                    this.threads = myAppSettings.threads;
                    this.perl = myAppSettings.perl;
                    this.bayes = myAppSettings.bayes;
                    this.iqtree = myAppSettings.iqtree;
                    this.figtree = myAppSettings.figtree;
                    this.paupup = myAppSettings.paupup;
                    this.imagemagick = myAppSettings.imagemagick;
                    this.readseq = myAppSettings.readseq;
                    this.sate = myAppSettings.sate;
                    this.similarity = myAppSettings.similarity;
                    this.muscle = myAppSettings.muscle;
                    this.fasttree = myAppSettings.fasttree;
                    this.sequencematrix = myAppSettings.sequencematrix;
                    fileExists = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (myFileStream != null)
                {
                    myFileStream.Close();
                }
            }

            if (progsdir == null)
            {
                progsdir = Environment.GetFolderPath(
                   System.Environment.SpecialFolder.Personal);
                this.appSettingsChanged = true;
            }
            return fileExists;
        }
    } 
}
