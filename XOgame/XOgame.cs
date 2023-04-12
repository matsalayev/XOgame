using System.Runtime.InteropServices;

namespace XOgame
{
    public partial class XOgame : Form
    {
        char navbat = 'x';
        bool check = true;
        string player = "";
        string program = "";
        public XOgame()
        {
            InitializeComponent();
            
        }      
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (check)
            {
                Boshlash obj = new Boshlash();
                obj.ShowDialog();
                check = false;                
                if (Class1.who == 'x')
                {
                    player = "❌";
                    program = "⭕";
                   
                }
                else if (Class1.who == 'o')
                {
                    player = "⭕";
                    program = "❌";
                }
                if (!Class1.program)
                {
                    btnNavbat.Text = "⚫";
                    btnNavbat.ForeColor = Color.Green;
                }                
                else btnNavbat.Text = "";
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Boshlash obj = new Boshlash();
            obj.ShowDialog();
            check = false;
            x = 0;
            o = 0;
            if (Class1.who == 'x')
            {
                player = "❌";
                program = "⭕";
            }
            else if (Class1.who == 'o')
            {
                player = "⭕";
                program = "❌";
            }
            if (!Class1.program)
            {
                btnNavbat.Text = "⚫";
                btnNavbat.ForeColor = Color.Green;
            }
            else btnNavbat.Text = "";
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
            button1.ForeColor = button2.ForeColor = button3.ForeColor = button5.ForeColor = button4.ForeColor = button6.ForeColor = button9.ForeColor = button8.ForeColor = button7.ForeColor = Color.White;
            f = true; win = ""; w = true;
            label1.Text = x.ToString();
            label2.Text = o.ToString();

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int x = 0; int o = 0;
        string win = ""; bool w = true;
        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (navbat == 'x' && button.Text == "" && win == "")
            {
                button.Text = player;
                navbat = 'o';
                if (!Class1.program) btnNavbat.ForeColor = Color.Red;
                if (Class1.who=='x') button.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.GraphicsUnit.Point);
                else button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                if (button1.Text == button2.Text && button2.Text == button3.Text && button2.Text == player)
                {
                    button1.ForeColor = button2.ForeColor = button3.ForeColor = Color.Green;
                    win = "x";
                }
                else if (button1.Text == button4.Text && button4.Text == button7.Text && button4.Text == player)
                {
                    button1.ForeColor = button4.ForeColor = button7.ForeColor = Color.Green;
                    win = "x";
                }
                else if (button1.Text == button5.Text && button5.Text == button9.Text && button5.Text == player)
                {
                    button1.ForeColor = button5.ForeColor = button9.ForeColor = Color.Green;
                    win = "x";
                }
                else if (button5.Text == button2.Text && button2.Text == button8.Text && button2.Text == player)
                {
                    button5.ForeColor = button2.ForeColor = button8.ForeColor = Color.Green;
                    win = "x";
                }
                else if (button5.Text == button4.Text && button4.Text == button6.Text && button4.Text == player)
                {
                    button5.ForeColor = button4.ForeColor = button6.ForeColor = Color.Green;
                    win = "x";
                }
                else if (button5.Text == button3.Text && button3.Text == button7.Text && button3.Text == player)
                {
                    button5.ForeColor = button3.ForeColor = button7.ForeColor = Color.Green;
                    win = "x";
                }
                else if (button9.Text == button6.Text && button6.Text == button3.Text && button6.Text == player)
                {
                    button9.ForeColor = button6.ForeColor = button3.ForeColor = Color.Green;
                    win = "x";
                }
                else if (button9.Text == button8.Text && button8.Text == button7.Text && button8.Text == player)
                {
                    button9.ForeColor = button8.ForeColor = button7.ForeColor = Color.Green;
                    win = "x";
                }
            }
            if (win == "x" && w) 
            { 
                w = false; x++; 
                btnNavbat.Text = "G'alaba!";
                btnNavbat.ForeColor = Color.Green;
            }            
            if (Class1.program)
            {
                if (button1.Text == "" ||
                button2.Text == "" ||
                button3.Text == "" ||
                button4.Text == "" ||
                button5.Text == "" ||
                button6.Text == "" ||
                button7.Text == "" ||
                button8.Text == "" ||
                button9.Text == "") dastur();
                else if (win == "")
                {
                    Durrang obj = new Durrang();
                    obj.ShowDialog();
                    button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
                    button1.ForeColor = button2.ForeColor = button3.ForeColor = button5.ForeColor = button4.ForeColor = button6.ForeColor = button9.ForeColor = button8.ForeColor = button7.ForeColor = Color.White;
                    f = true; win = ""; w = true;
                    if (navbat == 'x') navbat = 'o';

                    else navbat = 'x';
                    
                    dastur();
                }
                tekshr();
                
            }
            else
            {
                if (navbat == 'o' && button.Text == "" && win == "")
                {
                    button.Text = program;
                    navbat = 'x';
                    btnNavbat.ForeColor = Color.Green;
                    if (Class1.who == 'o') button.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.GraphicsUnit.Point);
                    else button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    tekshr();                  
                }
                if (button1.Text != "" &&
                button2.Text != "" &&
                button3.Text != "" &&
                button4.Text != "" &&
                button5.Text != "" &&
                button6.Text != "" &&
                button7.Text != "" &&
                button8.Text != "" &&
                button9.Text != "")
                {
                    tekshr();
                    if (win == "")
                    {
                        Durrang obj = new Durrang();
                        obj.ShowDialog();
                        button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
                        button1.ForeColor = button2.ForeColor = button3.ForeColor = button5.ForeColor = button4.ForeColor = button6.ForeColor = button9.ForeColor = button8.ForeColor = button7.ForeColor = Color.White;
                        
                        f = true; win = "";
                        if (navbat == 'x')
                        {
                            navbat = 'o';
                            btnNavbat.ForeColor = Color.Red;
                        }
                        else
                        {
                            navbat = 'x';
                            btnNavbat.ForeColor = Color.Green;
                        }
                    }
                }
            }

            label1.Text = x.ToString();
            label2.Text = o.ToString();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
            button1.ForeColor = button2.ForeColor = button3.ForeColor = button5.ForeColor = button4.ForeColor = button6.ForeColor = button9.ForeColor = button8.ForeColor = button7.ForeColor = Color.White;
            f = true; win = ""; w = true;
            if (navbat == 'x')
            {
                navbat = 'o';
                if (!Class1.program)
                {
                    btnNavbat.Text = "⚫";
                    btnNavbat.ForeColor = Color.Red;
                }
                else btnNavbat.Text = "";
                
            }
            else
            {
                navbat = 'x';
                if (!Class1.program)
                {
                    btnNavbat.Text = "⚫";
                    btnNavbat.ForeColor = Color.Green;
                }
                else btnNavbat.Text = "";
            }
            if (Class1.program) dastur();
            
        }
        Random ran = new Random();
        bool f = true;
        void dastur()
        {
            
            if (navbat == 'o' && win == "")
            {
                if (button1.Text == program && button2.Text == button1.Text && button3.Text == "") yoz(3);
                else if (button1.Text == program && button3.Text == button1.Text && button2.Text == "") yoz(2);
                else if (button1.Text == program && button4.Text == button1.Text && button7.Text == "") yoz(7);
                else if (button1.Text == program && button7.Text == button1.Text && button4.Text == "") yoz(4);
                else if (button1.Text == program && button5.Text == button1.Text && button9.Text == "") yoz(9);
                else if (button1.Text == program && button9.Text == button1.Text && button5.Text == "") yoz(5);

                else if (button2.Text == program && button1.Text == button2.Text && button3.Text == "") yoz(3);
                else if (button2.Text == program && button3.Text == button2.Text && button1.Text == "") yoz(1);
                else if (button2.Text == program && button5.Text == button2.Text && button8.Text == "") yoz(8);
                else if (button2.Text == program && button8.Text == button1.Text && button5.Text == "") yoz(5);

                else if (button3.Text == program && button1.Text == button3.Text && button2.Text == "") yoz(2);
                else if (button3.Text == program && button2.Text == button3.Text && button1.Text == "") yoz(1);
                else if (button3.Text == program && button6.Text == button3.Text && button9.Text == "") yoz(9);
                else if (button3.Text == program && button9.Text == button3.Text && button6.Text == "") yoz(6);
                else if (button3.Text == program && button5.Text == button3.Text && button7.Text == "") yoz(7);
                else if (button3.Text == program && button7.Text == button3.Text && button5.Text == "") yoz(5);

                else if (button4.Text == program && button7.Text == button4.Text && button1.Text == "") yoz(1);
                else if (button4.Text == program && button1.Text == button4.Text && button7.Text == "") yoz(7);
                else if (button4.Text == program && button5.Text == button4.Text && button6.Text == "") yoz(6);
                else if (button4.Text == program && button6.Text == button4.Text && button5.Text == "") yoz(5);

                else if (button5.Text == program && button1.Text == button5.Text && button9.Text == "") yoz(9);
                else if (button5.Text == program && button2.Text == button5.Text && button8.Text == "") yoz(8);
                else if (button5.Text == program && button3.Text == button5.Text && button7.Text == "") yoz(7);
                else if (button5.Text == program && button4.Text == button5.Text && button6.Text == "") yoz(6);
                else if (button5.Text == program && button6.Text == button5.Text && button4.Text == "") yoz(4);
                else if (button5.Text == program && button7.Text == button5.Text && button3.Text == "") yoz(3);
                else if (button5.Text == program && button8.Text == button5.Text && button2.Text == "") yoz(2);
                else if (button5.Text == program && button9.Text == button5.Text && button1.Text == "") yoz(1);

                else if (button6.Text == program && button3.Text == button6.Text && button9.Text == "") yoz(9);
                else if (button6.Text == program && button9.Text == button6.Text && button3.Text == "") yoz(3);
                else if (button6.Text == program && button5.Text == button6.Text && button4.Text == "") yoz(4);
                else if (button6.Text == program && button4.Text == button6.Text && button5.Text == "") yoz(5);

                else if (button7.Text == program && button4.Text == button7.Text && button1.Text == "") yoz(6);
                else if (button7.Text == program && button1.Text == button7.Text && button4.Text == "") yoz(4);
                else if (button7.Text == program && button8.Text == button7.Text && button9.Text == "") yoz(9);
                else if (button7.Text == program && button9.Text == button7.Text && button8.Text == "") yoz(8);
                else if (button7.Text == program && button5.Text == button7.Text && button3.Text == "") yoz(3);
                else if (button7.Text == program && button3.Text == button7.Text && button5.Text == "") yoz(5);

                else if (button8.Text == program && button9.Text == button8.Text && button7.Text == "") yoz(7);
                else if (button8.Text == program && button7.Text == button8.Text && button9.Text == "") yoz(9);
                else if (button8.Text == program && button5.Text == button8.Text && button2.Text == "") yoz(2);
                else if (button8.Text == program && button2.Text == button8.Text && button5.Text == "") yoz(5);
                else if (button8.Text == program && button5.Text == button8.Text && button2.Text == "") yoz(2);

                else if (button9.Text == program && button8.Text == button9.Text && button7.Text == "") yoz(7);
                else if (button9.Text == program && button7.Text == button9.Text && button8.Text == "") yoz(8);
                else if (button9.Text == program && button6.Text == button9.Text && button3.Text == "") yoz(3);
                else if (button9.Text == program && button3.Text == button9.Text && button6.Text == "") yoz(6);
                else if (button9.Text == program && button5.Text == button9.Text && button1.Text == "") yoz(1);
                else if (button9.Text == program && button1.Text == button9.Text && button5.Text == "") yoz(5);

                else if (button1.Text == player && button6.Text == player && button5.Text == "") { f = false; yoz(5); }
                else if (button3.Text == player && button8.Text == player && button5.Text == "") { f = false; yoz(5); }               
                else if (button7.Text == player && button6.Text == player && button5.Text == "") { f = false; yoz(5); }
                else if (button9.Text == player && button4.Text == player && button5.Text == "") { f = false; yoz(5); }
                else if (button3.Text == player && button6.Text == player && button5.Text == "") { f = false; yoz(5); }

                else if (button1.Text == player && button8.Text == "" && button5.Text == "" && f) { f = false; yoz(5); }
                else if (button3.Text == player && button4.Text == "" && button5.Text == "" && f) { f = false; yoz(5); }
                else if (button7.Text == player && button6.Text == "" && button5.Text == "" && f) { f = false; yoz(5); }
                else if (button9.Text == player && button2.Text == "" && button5.Text == "" && f) { f = false; yoz(5); }

                else if (button1.Text == player && button2.Text == button1.Text && button3.Text == "") yoz(3);
                else if (button1.Text == player && button3.Text == button1.Text && button2.Text == "") yoz(2);
                else if (button1.Text == player && button4.Text == button1.Text && button7.Text == "") yoz(7);
                else if (button1.Text == player && button7.Text == button1.Text && button4.Text == "") yoz(4);
                else if (button1.Text == player && button5.Text == button1.Text && button9.Text == "") yoz(9);
                else if (button1.Text == player && button9.Text == button1.Text && button5.Text == "") yoz(5);

                else if (button2.Text == player && button1.Text == button2.Text && button3.Text == "") yoz(3);
                else if (button2.Text == player && button3.Text == button2.Text && button1.Text == "") yoz(1);
                else if (button2.Text == player && button5.Text == button2.Text && button8.Text == "") yoz(8);
                else if (button2.Text == player && button8.Text == button1.Text && button5.Text == "") yoz(5);

                else if (button3.Text == player && button1.Text == button3.Text && button2.Text == "") yoz(2);
                else if (button3.Text == player && button2.Text == button3.Text && button1.Text == "") yoz(1);
                else if (button3.Text == player && button6.Text == button3.Text && button9.Text == "") yoz(9);
                else if (button3.Text == player && button9.Text == button3.Text && button6.Text == "") yoz(6);
                else if (button3.Text == player && button5.Text == button3.Text && button7.Text == "") yoz(7);
                else if (button3.Text == player && button7.Text == button3.Text && button5.Text == "") yoz(5);

                else if (button4.Text == player && button7.Text == button4.Text && button1.Text == "") yoz(1);
                else if (button4.Text == player && button1.Text == button4.Text && button7.Text == "") yoz(7);
                else if (button4.Text == player && button5.Text == button4.Text && button6.Text == "") yoz(6);
                else if (button4.Text == player && button6.Text == button4.Text && button5.Text == "") yoz(5);

                else if (button5.Text == player && button1.Text == button5.Text && button9.Text == "") yoz(9);
                else if (button5.Text == player && button2.Text == button5.Text && button8.Text == "") yoz(8);
                else if (button5.Text == player && button3.Text == button5.Text && button7.Text == "") yoz(7);
                else if (button5.Text == player && button4.Text == button5.Text && button6.Text == "") yoz(6);
                else if (button5.Text == player && button6.Text == button5.Text && button4.Text == "") yoz(4);
                else if (button5.Text == player && button7.Text == button5.Text && button3.Text == "") yoz(3);
                else if (button5.Text == player && button8.Text == button5.Text && button2.Text == "") yoz(2);
                else if (button5.Text == player && button9.Text == button5.Text && button1.Text == "") yoz(1);

                else if (button6.Text == player && button3.Text == button6.Text && button9.Text == "") yoz(9);
                else if (button6.Text == player && button9.Text == button6.Text && button3.Text == "") yoz(3);
                else if (button6.Text == player && button5.Text == button6.Text && button4.Text == "") yoz(4);
                else if (button6.Text == player && button4.Text == button6.Text && button5.Text == "") yoz(5);

                else if (button7.Text == player && button4.Text == button7.Text && button1.Text == "") yoz(6);
                else if (button7.Text == player && button1.Text == button7.Text && button4.Text == "") yoz(4);
                else if (button7.Text == player && button8.Text == button7.Text && button9.Text == "") yoz(9);
                else if (button7.Text == player && button9.Text == button7.Text && button8.Text == "") yoz(8);
                else if (button7.Text == player && button5.Text == button7.Text && button3.Text == "") yoz(3);
                else if (button7.Text == player && button3.Text == button7.Text && button5.Text == "") yoz(5);

                else if (button8.Text == player && button9.Text == button8.Text && button7.Text == "") yoz(7);
                else if (button8.Text == player && button7.Text == button8.Text && button9.Text == "") yoz(9);
                else if (button8.Text == player && button5.Text == button8.Text && button2.Text == "") yoz(2);
                else if (button8.Text == player && button2.Text == button8.Text && button5.Text == "") yoz(5);
                else if (button8.Text == player && button5.Text == button8.Text && button2.Text == "") yoz(2);

                else if (button9.Text == player && button8.Text == button9.Text && button7.Text == "") yoz(7);
                else if (button9.Text == player && button7.Text == button9.Text && button8.Text == "") yoz(8);
                else if (button9.Text == player && button6.Text == button9.Text && button3.Text == "") yoz(3);
                else if (button9.Text == player && button3.Text == button9.Text && button6.Text == "") yoz(6);
                else if (button9.Text == player && button5.Text == button9.Text && button1.Text == "") yoz(1);
                else if (button9.Text == player && button1.Text == button9.Text && button5.Text == "") yoz(5);

                else yoz(ran.Next(1, 10));
                navbat = 'x';
                
            }
        }
        void yoz(int a)
        {
            
            switch (a)
            {
                case 1:
                    if (button1.Text == "")
                    {
                        button1.Text = program;
                        if (Class1.who == 'o') button1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.GraphicsUnit.Point);
                        else button1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                        button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    else dastur();
                    break;
                case 2:
                    if (button2.Text == "")
                    {
                        button2.Text = program;
                        if (Class1.who == 'o') button2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.GraphicsUnit.Point);
                        else button2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                        button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    else dastur();
                    break;
                case 3:
                    if (button3.Text == "")
                    {
                        button3.Text = program;
                        if (Class1.who == 'o') button3.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.GraphicsUnit.Point);
                        else button3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); win = "";
                        button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    else dastur();
                    break;
                case 4:
                    if (button4.Text == "")
                    {
                        button4.Text = program;
                        if (Class1.who == 'o') button4.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.GraphicsUnit.Point);
                        else button4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                        button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    else dastur();
                    break;
                case 5:
                    if (button5.Text == "")
                    {
                        button5.Text = program;
                        if (Class1.who == 'o') button5.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.GraphicsUnit.Point);
                        else button5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                        button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    else dastur();
                    break;
                case 6:
                    if (button6.Text == "")
                    {
                        button6.Text = program;
                        if (Class1.who == 'o') button6.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.GraphicsUnit.Point);
                        else button6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                        button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    else dastur();
                    break;
                case 7:
                    if (button7.Text == "")
                    {
                        button7.Text = program;
                        if (Class1.who == 'o') button7.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.GraphicsUnit.Point);
                        else button7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                        button7.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    else dastur();
                    break;
                case 8:
                    if (button8.Text == "")
                    {
                        button8.Text = program;
                        if (Class1.who == 'o') button8.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.GraphicsUnit.Point);
                        else button8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                        button8.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    else dastur();
                    break;
                case 9:
                    if (button9.Text == "")
                    {
                        button9.Text = program;
                        if (Class1.who == 'o') button9.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.GraphicsUnit.Point);
                        else button9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                        button9.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    else dastur();
                    break;
            }
            if (button1.Text != "" &&
                button2.Text != "" &&
                button3.Text != "" &&
                button4.Text != "" &&
                button5.Text != "" &&
                button6.Text != "" &&
                button7.Text != "" &&
                button8.Text != "" &&
                button9.Text != "" )
            {
                tekshr();
                if (win == "")
                {
                    Durrang obj = new Durrang();
                    obj.ShowDialog();
                    button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
                    button1.ForeColor = button2.ForeColor = button3.ForeColor = button5.ForeColor = button4.ForeColor = button6.ForeColor = button9.ForeColor = button8.ForeColor = button7.ForeColor = Color.White;
                    btnNavbat.Text = "";
                    f = true; win = "";
                    if (navbat == 'x') navbat = 'o';

                    else navbat = 'x';

                    dastur();
                }                
            }
        }
        void tekshr()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button2.Text == program)
            {
                button1.ForeColor = button2.ForeColor = button3.ForeColor = Color.Red;
                win = "o";
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button4.Text == program)
            {
                button1.ForeColor = button4.ForeColor = button7.ForeColor = Color.Red;
                win = "o";
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button5.Text == program)
            {
                button1.ForeColor = button5.ForeColor = button9.ForeColor = Color.Red;
                win = "o";
            }
            else if (button5.Text == button2.Text && button2.Text == button8.Text && button2.Text == program)
            {
                button5.ForeColor = button2.ForeColor = button8.ForeColor = Color.Red;
                win = "o";
            }
            else if (button5.Text == button4.Text && button4.Text == button6.Text && button4.Text == program)
            {
                button5.ForeColor = button4.ForeColor = button6.ForeColor = Color.Red;
                win = "o";
            }
            else if (button5.Text == button3.Text && button3.Text == button7.Text && button3.Text == program)
            {
                button5.ForeColor = button3.ForeColor = button7.ForeColor = Color.Red;
                win = "o";
            }
            else if (button9.Text == button6.Text && button6.Text == button3.Text && button6.Text == program)
            {
                button9.ForeColor = button6.ForeColor = button3.ForeColor = Color.Red;
                win = "o";
            }
            else if (button9.Text == button8.Text && button8.Text == button7.Text && button8.Text == program)
            {
                button9.ForeColor = button8.ForeColor = button7.ForeColor = Color.Red;
                win = "o";
            }
            if (win == "o" && w) 
            {
                w = false; o++;
                btnNavbat.Text = "G'alaba!";
                btnNavbat.ForeColor = Color.Red;
            }
            
            label1.Text = x.ToString();
            label2.Text = o.ToString();
        }

        private void btnNavbat_MouseHover(object sender, EventArgs e)
        {
            if(!Class1.program) btnNavbat.Text = "Navbat";
        }

        private void btnNavbat_MouseLeave(object sender, EventArgs e)
        {
            if (!Class1.program)
                btnNavbat.Text = "⚫";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}