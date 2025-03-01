using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_sistemas
{
    public class RoundPanel : Panel
    {
        // Radio de las esquinas
        public int CornerRadius { get; set; } = 20;

        // Sobrescribimos el método OnPaint para dibujar el panel con esquinas redondeadas
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Dibujamos un panel con esquinas redondeadas usando un pincel y un borde
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90); // Esquina superior izquierda
                path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90); // Esquina superior derecha
                path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90); // Esquina inferior derecha
                path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90); // Esquina inferior izquierda
                path.CloseAllFigures();

                // Aplicamos el path a la región del panel
                this.Region = new Region(path);

                // Dibujamos un borde alrededor del panel (opcional)
                e.Graphics.DrawPath(Pens.Black, path);
            }
        }
    }
}
