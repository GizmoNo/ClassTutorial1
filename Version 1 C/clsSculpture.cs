using System;


namespace Version_1_C
{
    [Serializable()]
    public class clsSculpture : clsWork
    {
        private float _Weight;
        private string _Material;

        [NonSerialized()]
        private frmSculpture _sculptureDialog;

        public float Weight { get => _Weight; set => _Weight = value; }
        public string Material { get => _Material; set => _Material = value; }

        public override void EditDetails()
        {
            if ( _sculptureDialog == null)
                 _sculptureDialog = frmSculpture.Sculpture;
            _sculptureDialog.SetDetails(this);
            
        }
        
                 
    }
    
}
