using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Graph graph = new Graph();

        private System.Windows.Forms.Timer truckTimer = new System.Windows.Forms.Timer();

        private List<Point> animationPoints = new List<Point>();

        private int currentAnimationIndex = 0;

        private Bitmap? originalMap;

        private Image? truckIcon;

        Dictionary<string, Point> cityPoints = new Dictionary<string, Point>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCities();

            LoadGraph();

            LoadMapPoints();

            dgvDistance.RowHeadersVisible = false;

            dgvDistance.AllowUserToAddRows = false;

            dgvDistance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvDistance.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            lblStatus.Items.Clear();

            lblStatus.Items.Add("Ready");

            originalMap = new Bitmap(picmap.Image);

            truckIcon = Properties.Resources.truck;

            MessageBox.Show(Properties.Resources.truck == null? "NULL" : "OK");
        }

        private void LoadCities()
        {
            string[] cities =
            {
                "Lai Chau",
                "Dien Bien",
                "Lao Cai",
                "Son La",
                "Ha Giang",
                "Cao Bang",
                "Tuyen Quang",
                "Thai Nguyen",
                "Lang Son",
                "Quang Ninh",
                "Phu Tho",
                "Bac Ninh",
                "Ha Noi",
                "Hai Phong",
                "Ninh Binh",
                "Thanh Hoa",
                "Nghe An",
                "Ha Tinh",
                "Quang Tri",
                "Hue",
                "Da Nang",
                "Quang Ngai",
                "Gia Lai",
                "Dak Lak",
                "Khanh Hoa",
                "Lam Dong",
                "Tay Ninh",
                "Dong Nai",
                "HCM",
                "Ba Ria Vung Tau",
                "Dong Thap",
                "Vinh Long",
                "An Giang",
                "Can Tho",
                "Ca Mau"
            };
            comboStartPoint.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            comboStartPoint.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboDestination.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            comboDestination.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboStartPoint.Items.AddRange(cities);

            comboDestination.Items.AddRange(cities);

            comboStartPoint.SelectedIndex = 0;

            comboDestination.SelectedIndex = 1;
        }

        private void LoadGraph()
        {
            graph.AddEdge("Ha Noi", "Hai Phong", 120);
            graph.AddEdge("Ha Noi", "Ninh Binh", 95);
            graph.AddEdge("Ha Noi", "Thai Nguyen", 80);
            graph.AddEdge("Ha Noi", "Bac Ninh", 35);
            graph.AddEdge("Ha Noi", "Phu Tho", 90);
            graph.AddEdge("Ha Noi", "Lang Son", 155);
            graph.AddEdge("Ninh Binh", "Thanh Hoa", 135);
            graph.AddEdge("Thanh Hoa", "Nghe An", 145);
            graph.AddEdge("Nghe An", "Ha Tinh", 50);
            graph.AddEdge("Ha Tinh", "Quang Tri", 140);
            graph.AddEdge("Quang Tri", "Hue", 70);
            graph.AddEdge("Hue", "Da Nang", 100);
            graph.AddEdge("Da Nang", "Quang Ngai", 130);
            graph.AddEdge("Quang Ngai", "Gia Lai", 180);
            graph.AddEdge("Gia Lai", "Dak Lak", 180);
            graph.AddEdge("Dak Lak", "Lam Dong", 210);
            graph.AddEdge("Lam Dong", "Dong Nai", 230);
            graph.AddEdge("Dong Nai", "HCM", 35);
            graph.AddEdge("HCM", "Ba Ria Vung Tau", 95);
            graph.AddEdge("HCM", "Tay Ninh", 100);
            graph.AddEdge("HCM", "Vinh Long", 135);
            graph.AddEdge("Vinh Long", "Can Tho", 35);
            graph.AddEdge("Can Tho", "Ca Mau", 150);
            graph.AddEdge("Vinh Long", "Dong Thap", 80);
            graph.AddEdge("Dong Thap", "An Giang", 60);
            graph.AddEdge("Da Nang", "Khanh Hoa", 520);
            graph.AddEdge("Khanh Hoa", "Lam Dong", 140);
            graph.AddEdge("Lao Cai", "Ha Giang", 230);
            graph.AddEdge("Lao Cai", "Lai Chau", 110);
            graph.AddEdge("Lai Chau", "Dien Bien", 100);
            graph.AddEdge("Son La", "Dien Bien", 150);
            graph.AddEdge("Son La", "Phu Tho", 180);
            graph.AddEdge("Ha Giang", "Cao Bang", 240);
            graph.AddEdge("Cao Bang", "Lang Son", 120);
            graph.AddEdge("Thai Nguyen", "Bac Ninh", 70);
            graph.AddEdge("Hai Phong", "Quang Ninh", 80);
        }

        private void LoadMapPoints()
        {
            cityPoints.Clear();

            // ===== MIỀN BẮC =====

            cityPoints["Lai Chau"] = new Point(157, 130);
            cityPoints["Dien Bien"] = new Point(166, 229);
            cityPoints["Lao Cai"] = new Point(290, 188);
            cityPoints["Son La"] = new Point(278, 245);
            cityPoints["Ha Giang"] = new Point(395, 51);
            cityPoints["Cao Bang"] = new Point(515, 95);
            cityPoints["Tuyen Quang"] = new Point(401, 145);
            cityPoints["Thai Nguyen"] = new Point(486, 185);
            cityPoints["Lang Son"] = new Point(600, 190);
            cityPoints["Quang Ninh"] = new Point(655, 272);
            cityPoints["Phu Tho"] = new Point(404, 280);
            cityPoints["Bac Ninh"] = new Point(530, 275);
            cityPoints["Ha Noi"] = new Point(475, 355);
            cityPoints["Hai Phong"] = new Point(565, 345);
            cityPoints["Ninh Binh"] = new Point(437, 406);
            cityPoints["Thanh Hoa"] = new Point(401, 467);
            cityPoints["Nghe An"] = new Point(340, 532);
            cityPoints["Ha Tinh"] = new Point(430, 612);

            // ===== MIỀN TRUNG =====

            cityPoints["Quang Tri"] = new Point(505, 693);
            cityPoints["Hue"] = new Point(597, 750);
            cityPoints["Da Nang"] = new Point(645, 800);
            cityPoints["Quang Ngai"] = new Point(679, 862);

            // ===== TÂY NGUYÊN =====

            cityPoints["Gia Lai"] = new Point(609, 902);
            cityPoints["Dak Lak"] = new Point(605, 983);
            cityPoints["Khanh Hoa"] = new Point(731, 985);
            cityPoints["Lam Dong"] = new Point(672, 1087);

            // ===== ĐÔNG NAM BỘ =====

            cityPoints["Tay Ninh"] = new Point(471, 1118);
            cityPoints["Dong Nai"] = new Point(568, 1114);
            cityPoints["HCM"] = new Point(522, 1181);
            cityPoints["Ba Ria Vung Tau"] = new Point(635, 1235);

            // ===== MIỀN TÂY =====

            cityPoints["Dong Thap"] = new Point(387, 1194);
            cityPoints["Vinh Long"] = new Point(462, 1242);
            cityPoints["An Giang"] = new Point(301, 1278);
            cityPoints["Can Tho"] = new Point(440, 1381);
            cityPoints["Ca Mau"] = new Point(315, 1386);
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            string start =comboStartPoint.SelectedItem?.ToString() ?? "";

            string end = comboDestination.SelectedItem?.ToString() ?? "";

            var result = Dijkstra.FindShortestPath(graph, start, end);

            double totalDistance = result.distance;

            double gasoline = totalDistance * 0.15;

            double transportCost = gasoline * 25000;

            double time = totalDistance / 50.0;

            textBox1.Text = gasoline.ToString("0.00") + " L";

            textBox2.Text = totalDistance.ToString("0.00") + " km";

            textBox4.Text = transportCost.ToString("N0") + " VND";

            textBox5.Text = time.ToString("0.00") + " h";



            dgvDistance.Rows.Clear();

            for (int i = 0; i < result.path.Count - 1; i++)
            {
                string from = result.path[i];

                string to = result.path[i + 1];

                double distance = 0;

                foreach (var edge in graph.AdjacencyList[from])
                {
                    if (edge.Destination == to)
                    {
                        distance = edge.Distance;
                        break;
                    }
                }

                dgvDistance.Rows.Add(from + " -> " + to, from, distance + " km");
            }

            StartTruckAnimation(result.path);
        }

        private void DrawPath(List<string> path)
        {
            Bitmap bmp = new Bitmap(picmap.Image);

            Graphics g = Graphics.FromImage(bmp);

            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen pen = new Pen(Color.Red, 8);

            pen.StartCap = LineCap.Round;

            pen.EndCap = LineCap.Round;

            for (int i = 0; i < path.Count - 1; i++)
            {
                Point p1 = cityPoints[path[i]];

                Point p2 = cityPoints[path[i + 1]];

                // LINE

                g.DrawLine(pen, p1, p2);

                // POINT START

                g.FillEllipse(Brushes.Yellow, p1.X - 10, p1.Y - 10, 20, 20);

                // POINT END

                g.FillEllipse(Brushes.Lime, p2.X - 10, p2.Y - 10, 20, 20);
            }

            picmap.Image = bmp;
        }

        private void comboStartPoint_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxOptions_Enter(object sender, EventArgs e)
        {

        }

        private void picmap_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void StartTruckAnimation(List<string> path)
        {
            animationPoints.Clear();

            currentAnimationIndex = 0;

            for (int i = 0; i < path.Count - 1; i++)
            {
                Point start = cityPoints[path[i]];

                Point end = cityPoints[path[i + 1]];

                int steps = 20;

                for (int s = 0; s <= steps; s++)
                {
                    int x = start.X + (end.X - start.X) * s / steps;

                    int y = start.Y + (end.Y - start.Y) * s / steps;

                    animationPoints.Add(new Point(x, y));
                }
            }

            truckTimer.Interval = 12;

            truckTimer.Tick -= TruckTimer_Tick;

            truckTimer.Tick += TruckTimer_Tick;

            truckTimer.Start();
        }
        private void TruckTimer_Tick(object sender, EventArgs e)
        {
            if (currentAnimationIndex >= animationPoints.Count)
            {
                truckTimer.Stop();
                return;
            }

            Bitmap bmp = new Bitmap(originalMap);

            Graphics g = Graphics.FromImage(bmp);

            g.SmoothingMode = SmoothingMode.AntiAlias;

            // =====================
            // VẼ ĐƯỜNG
            // =====================

            Pen pen = new Pen(Color.Red, 8);

            pen.StartCap = LineCap.Round;

            pen.EndCap = LineCap.Round;

            for (int i = 0; i < currentAnimationIndex; i++)
            {
                if (i >= animationPoints.Count - 1) break;

                g.DrawLine(pen, animationPoints[i], animationPoints[i + 1]);
            }

            // =====================
            // VẼ XE TẢI
            // =====================

            Point truckPos = animationPoints[currentAnimationIndex];

            if (truckIcon != null)
            {
                g.DrawImage(truckIcon, truckPos.X - 20, truckPos.Y - 20, 40, 40);
            }

            picmap.Image = bmp;

            currentAnimationIndex++;
        }
    }
}
