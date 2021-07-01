namespace ThirdTask
{
    public class Notebook : Device
    {
        public bool RgbKeyboard { get; init; } 
        public bool WebCam { get; init; }
        public int USBPorts { get; init; }
        
        public Notebook(){}
        
        public Notebook (string company) : base(company) {}

        public Notebook(string company, string model, int price, bool rgbKeyboard, bool webCam, int usbPorts) : base(company, model, price)
        {
            RgbKeyboard = rgbKeyboard;
            WebCam = webCam;
            USBPorts = usbPorts;
        }
        
        public string GetNoteookInfo()
        {   
            return $"\nRGB Keyboard: {RgbKeyboard} \nWeb Camera: {WebCam} \nUSB ports: {USBPorts}";
        }

        public override string GetInfo()
        {
            return  $"\nCompany: {Company} \nModel: {Model} \nPrice: {Price}" + GetNoteookInfo() ;
        }
    } 
}