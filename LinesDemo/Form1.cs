//KabluchkovDS (c) 04 10 2022

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LinesDemo
{
    public partial class Form1 : Form
    {
        bool bDrug = false;
        bool bPointsActive = false;
        bool bParamsActive = false;
        bool bClearActive = false;
        bool bCurveActive = false;
        bool bPolygoneActive = false;
        bool bBezieActive = false;
        bool bFilledActive = false;
        bool bMoveActive = false;
        int curveType;
        int pointCaptured;

        //сброс подсветки кнопок
        void ButtonDeactivator(int i)
        {
            //для срабатывания вкл/выкл режима точек и режима движения
            if (i == 0)
            {
                bPointsActive = false;
                bMoveActive = false;
            }

            bParamsActive = false;
            bClearActive = false;
            bCurveActive = false;
            bPolygoneActive = false;
            bBezieActive = false;
            bFilledActive = false;

            Invalidate();
            Refresh();
        }

        static List<Point> points = new List<Point>();
        private Timer moveTimer = new Timer();

        public Form1()
        {
            InitializeComponent();
            //установка значений по умолчанию
            Settings.pointDiam = 10;
            Settings.lineTolsh = 5;
            curveType = 0;
            Settings.pointColour = Color.Red;
            Settings.lineColour = Color.Black;
            //настройки таймера
            moveTimer.Interval = 30;
            moveTimer.Tick += TimerTickHandler;

            KeyPreview = true;
        }

        //КНОПКА ТОЧКИ
        private void bPoints_Click(object sender, EventArgs e)
        {
            if (!bMoveActive)
            {
                ButtonDeactivator(1);
                bPointsActive = !bPointsActive;
                Refresh();
            }

        }

        //добавление точки к листу точек
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //работем только при активной кнопке ТОЧКИ
            if (bPointsActive)
            {
                //добавление точки по координатам курсора
                points.Add(new Point(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y));
                Invalidate();
            }
            Refresh();
        }

        //отрисовка!
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //отрисовка подсветки кнопок
            if (bPointsActive) bPoints.BackColor = Color.Red; else bPoints.BackColor = Control.DefaultBackColor;
            if (bParamsActive) bParams.BackColor = Color.Red; else bParams.BackColor = Control.DefaultBackColor;
            if (bClearActive) bClear.BackColor = Color.Red; else bClear.BackColor = Control.DefaultBackColor;
            if (bCurveActive) bCurve.BackColor = Color.Red; else bCurve.BackColor = Control.DefaultBackColor;
            if (bPolygoneActive) bPolygone.BackColor = Color.Red; else bPolygone.BackColor = Control.DefaultBackColor;
            if (bBezieActive) bBezie.BackColor = Color.Red; else bBezie.BackColor = Control.DefaultBackColor;
            if (bFilledActive) bFilled.BackColor = Color.Red; else bFilled.BackColor = Control.DefaultBackColor;

            if (bMoveActive) bMove.BackColor = Color.Red; else bMove.BackColor = Control.DefaultBackColor;

            //отрисовка точек
            Brush brush = new SolidBrush(Settings.pointColour);
            foreach (Point p in points)
                e.Graphics.FillEllipse(brush, p.X - (Settings.pointDiam / 2), p.Y - (Settings.pointDiam / 2), Settings.pointDiam, Settings.pointDiam);

            //отрисовка линии
            Pen pen = new Pen(Settings.lineColour, Settings.lineTolsh);
            if (curveType != 0)
            {
                switch (curveType)
                {
                    //КРИВАЯ
                    case 1:
                        if (points.Count > 2) //защита от ошибки
                        {
                            foreach (Point p in points)
                                e.Graphics.DrawClosedCurve(pen, points.ToArray());
                        }
                        else
                        {
                            curveType = 0;
                            bCurveActive = false;
                            var res = MessageBox.Show("Для постоения замкнутой кривой \n нужно не менее трёх точек.", "Мало точек!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    //ЛОМАНАЯ
                    case 2:
                        if (points.Count > 1) //защита от ошибки
                        {
                            foreach (Point p in points)
                                e.Graphics.DrawPolygon(pen, points.ToArray());
                        }
                        else
                        {
                            curveType = 0;
                            bPolygoneActive = false;
                            var res = MessageBox.Show("Для постоения ломаной кривой \n нужно не менее двух точек.", "Мало точек!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    //БЕЗЬЕ
                    case 3:
                        if ((points.Count - 1) % 3 == 0) //защита от ошибки
                        {
                            foreach (Point p in points)
                                e.Graphics.DrawBeziers(pen, points.ToArray());
                        }
                        else
                        {
                            curveType = 0;
                            bBezieActive = false;
                            var res = MessageBox.Show("Для постоения кривой безье нужно количество точкек \n кратное трём + 1, например: 1, 4, 7, 10...", "Не тот набор точек!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    //ЗАПОЛНЕННАЯ
                    case 4:
                        if (points.Count > 2) //защита от ошибки
                        {
                            foreach (Point p in points)
                                e.Graphics.FillClosedCurve(brush, points.ToArray());
                        }
                        else
                        {
                            curveType = 0;
                            bPolygoneActive = false;
                            var res = MessageBox.Show("Для постоения заполненной кривой \n нужно не менее трёх точек.", "Мало точек!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                }
            }

        }

        //КНОПКА ПАРАМЕТРЫ
        private void bParams_Click(object sender, EventArgs e)
        {
            ButtonDeactivator(0);
            bParamsActive = true;

            Form2 paramForm = new Form2();
            paramForm.Show();
            Refresh();
        }

        //КНОПКА ОЧИСТКА
        private void bClear_Click(object sender, EventArgs e)
        {
            ButtonDeactivator(0);
            bMoveActive = false;
            bClearActive = true;
            curveType = 0;
            points.Clear();
            Refresh();
        }

        //КНОПКА КРИВАЯ
        private void bCurve_Click(object sender, EventArgs e)
        {
            ButtonDeactivator(0);
            bCurveActive = true;
            curveType = 1;
            Refresh();
        }

        //КНОПКА ЛОМАНАЯ
        private void bPolygone_Click(object sender, EventArgs e)
        {
            ButtonDeactivator(0);
            bPolygoneActive = true;
            curveType = 2;
            Refresh();
        }

        //КНОПКА БЕЗЬЕ
        private void bBezie_Click(object sender, EventArgs e)
        {

            ButtonDeactivator(0);
            bBezieActive = true;
            curveType = 3;
            Refresh();
        }

        //КНОПКА ЗАПОЛНЕННАЯ
        private void bFilled_Click(object sender, EventArgs e)
        {
            ButtonDeactivator(0);
            bFilledActive = true;
            curveType = 4;
            Refresh();
        }

        //перерисовка при получении фокуса (после закрытия окна свойств)
        private void Form1_Activated(object sender, EventArgs e)
        {
            Refresh();
        }

        //кнопка мышки нажата
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //координата курсора
            Point mousePoint = new Point(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);

            //проверка координаты с допуском 10 пикселей на совпадение с какой-либо точкой массива
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i].X <= mousePoint.X + 5 + Settings.pointDiam / 2 && points[i].X >= mousePoint.X - 5 - Settings.pointDiam / 2 && points[i].Y <= mousePoint.Y + 5 + Settings.pointDiam / 2 && points[i].Y >= mousePoint.Y - 5 - Settings.pointDiam / 2) //доработать
                {
                    bDrug = true;
                    //  pointToDrag = points[i];
                    pointCaptured = i;
                    break;
                }
            }
        }

        //отпуск кнопки мыши
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bDrug = false;
            Refresh();
        }

        //движение мыши c нажатой кнопкой
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //если тащим точку
            if (bDrug)
            {
                points[pointCaptured] = new Point(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
                Refresh();
            }
        }


        //публичные переменные для движения//:

        //словарь для хранения стостояния точек. ключ - номер точки в листе
        //значение две цифры - состояние для каждой точки - 1 удар о левую/верхню стенку, -1 - удар о правую / нижнюю стенку.
        //словарь для Х
        Dictionary<int, int> collisionX = new Dictionary<int, int>();
        //словарь для Y
        Dictionary<int, int> collisionY = new Dictionary<int, int>();

        //КНОПКА ДВИЖЕНИЕ
        private void bMove_Click(object sender, EventArgs e)
        {
            ButtonDeactivator(1);
            bPointsActive = false;
            bMoveActive = !bMoveActive;
            if (bMoveActive)
            {
                //разовый экшн при нажатии кнопки движения       
                //чистим коллизии
                collisionX.Clear();
                collisionY.Clear();

                Random rnd = new Random();
                rnd = new Random();
                //заполняем словари (случайное направление точек по условию задачи)
                for (int i = 0; i < points.Count; i++)
                {
                    int rndGo = rnd.Next(2);
                    if (rndGo == 0) collisionX.Add(i, 1); else collisionX.Add(i, -1);
                    rndGo = rnd.Next(2);
                    if (rndGo == 0) collisionY.Add(i, 1); else collisionY.Add(i, -1);
                }
                moveTimer.Start();
            }
            else moveTimer.Stop();
            Refresh();
        }

        //обработка движения - всё что внутри, действует при нажатой кнопке ДВИЖЕНИЕ каждый ТИК
        void TimerTickHandler(object sender, EventArgs e)
        {
            //рабочая точка
            Point pointMoved = new Point();
            //пустой список для заполнения подвинутыми точками
            List<Point> pointsMove = new List<Point>();

            //проход по массиву точек, наполнение подвинутого листа точек
            for (int i = 0; i < points.Count; i++)
            {
                //проверка точки на предмет удара о стенку правую:
                if (points[i].X >= Size.Width - 20) collisionX[i] = -1;
                //проверка точки на предмет удара о стенку левую:
                if (points[i].X <= 0) collisionX[i] = 1;

                //проверка точки на предмет удара о стенку нижнюю:
                if (points[i].Y >= Size.Height - 40) collisionY[i] = -1;
                //проверка точки на предмет удара о стенку верхнюю:
                if (points[i].Y <= 0) collisionY[i] = 1;

                //если физика:
                if (radioPhysics.Checked)
                {
                    //двигаем временную точку
                    pointMoved = new Point(points[i].X + collisionX[i], points[i].Y + collisionY[i]);
                }
                else if (radioMad.Checked)
                {
                    //рандом движение
                    Random rnd = new Random();
                    int rndVal = rnd.Next(Convert.ToInt32(-numericMadness.Value + 1), Convert.ToInt32(numericMadness.Value));
                    if (points[i].X + rndVal < 0) rndVal = 0;
                    if (points[i].Y + rndVal < 0) rndVal = 0;
                    if (points[i].X + rndVal > Width) rndVal = 0;
                    if (points[i].Y + rndVal > Height) rndVal = 0;
                    pointMoved = new Point(points[i].X + rndVal, points[i].Y + rndVal);
                }

                //добавление точки в подвинутый лист
                pointsMove.Add(pointMoved);
            }

            //подмена изначального массива подменным подвинутым
            points = pointsMove;
            Refresh();
        }

        //радио баттоны
        private void radioPhysics_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPhysics.Checked) radioMad.Checked = false; else radioMad.Checked = true;
            numericMadness.Enabled = false;
        }

        private void radioMad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMad.Checked) radioPhysics.Checked = false; else radioPhysics.Checked = true;
            numericMadness.Enabled = true;
        }

        //КЛАВИАТУРА - обработка.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            //пробел - старт/стоп движения
            if ((Keys)e.KeyValue == Keys.Space) bMove.PerformClick();

            //эскейп - чистка
            if ((Keys)e.KeyValue == Keys.Escape)
            {
                points.Clear();
                curveType = 0;
                Refresh();
            }

            //плюс - ускорение точек
            if (((Keys)e.KeyValue == Keys.Oemplus || (Keys)e.KeyValue == Keys.Add) && (moveTimer.Interval - 5 > 0)) moveTimer.Interval -= 5;

            //минус - замедление точек
            if ((Keys)e.KeyValue == Keys.Oemplus || (Keys)e.KeyValue == Keys.Subtract) moveTimer.Interval += 5;

            //стрелка вверх + контрол - смещение точек вверх
            if ((Keys)e.KeyValue == Keys.Up)
            {
                //рабочая точка
                Point pointMoved = new Point();
                //пустой список для заполнения подвинутыми точками
                List<Point> pointsMove = new List<Point>();

                //проход по массиву точек, наполнение подвинутого листа точек
                for (int i = 0; i < points.Count; i++)
                {
                    //двигаем временную точку
                    pointMoved = new Point(points[i].X + 0, points[i].Y - 10);
                    pointsMove.Add(pointMoved);
                }
                points = pointsMove;
                Refresh();
            }

            //стрелка вниз + контрол - смещение точек вниз
            if ((Keys)e.KeyValue == Keys.Down)
            {
                //рабочая точка
                Point pointMoved = new Point();
                //пустой список для заполнения подвинутыми точками
                List<Point> pointsMove = new List<Point>();

                //проход по массиву точек, наполнение подвинутого листа точек
                for (int i = 0; i < points.Count; i++)
                {
                    //двигаем временную точку
                    pointMoved = new Point(points[i].X + 0, points[i].Y + 10);
                    pointsMove.Add(pointMoved);
                }
                points = pointsMove;
                Refresh();
            }

            //стрелка влево + контрол - смещение точек влево
            if ((Keys)e.KeyValue == Keys.Left)
            {
                //рабочая точка
                Point pointMoved = new Point();
                //пустой список для заполнения подвинутыми точками
                List<Point> pointsMove = new List<Point>();

                //проход по массиву точек, наполнение подвинутого листа точек
                for (int i = 0; i < points.Count; i++)
                {
                    //двигаем временную точку
                    pointMoved = new Point(points[i].X - 10, points[i].Y + 0);
                    pointsMove.Add(pointMoved);
                }
                points = pointsMove;
                Refresh();
            }

            //стрелка вправо + контрол - смещение точек вправо
            if ((Keys)e.KeyValue == Keys.Right)
            {
                //рабочая точка
                Point pointMoved = new Point();
                //пустой список для заполнения подвинутыми точками
                List<Point> pointsMove = new List<Point>();

                //проход по массиву точек, наполнение подвинутого листа точек
                for (int i = 0; i < points.Count; i++)
                {
                    //двигаем временную точку
                    pointMoved = new Point(points[i].X + 10, points[i].Y + 0);
                    pointsMove.Add(pointMoved);
                }
                points = pointsMove;
                Refresh();
            }


        }


    }



    static class Settings
    {
        public static int pointDiam { get; set; }
        public static int lineTolsh { get; set; }
        public static Color pointColour { get; set; }
        public static Color lineColour { get; set; }

    }
}
