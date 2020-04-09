using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docking_PreviewDockingHints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Label label1 = new Label() { Text = "The PreviewDockHints event occurs before displaying the dock hints " +
                "when drag the windows. The PreviewDockHintsEventArgs provides the following event data" +
                " for the PreviewDockHints event of DockingManager." };

          
            Label label3 = new Label()
            {
                Text = label1.Text
            };

            Label label4 = new Label()
            {
                Text = label1.Text
            };

            this.dockingManager1.SetEnableDocking(panel1, true);

            label1.Dock = DockStyle.Fill;
            label3.Dock = DockStyle.Fill;
            label4.Dock = DockStyle.Fill;


            this.dockingManager1.SetEnableDocking(panel2, true);

            this.dockingManager1.SetEnableDocking(panel3, true);

            this.dockingManager1.SetEnableDocking(panel4, true);

            dockingManager1.SetDockLabel(panel1, "Solution Explorer");

            dockingManager1.SetDockLabel(panel2, "Toolbox");

            dockingManager1.SetDockLabel(panel3, "Properties");

            dockingManager1.SetDockLabel(panel4, "Output");

            this.dockingManager1.DockControl(this.panel3, this, Syncfusion.Windows.Forms.Tools.DockingStyle.Bottom, 100);

            this.dockingManager1.DockControl(this.panel2, this, Syncfusion.Windows.Forms.Tools.DockingStyle.Left, 200);

            this.dockingManager1.DockControl(this.panel1, this, Syncfusion.Windows.Forms.Tools.DockingStyle.Right, 200);

            this.dockingManager1.DockControl(this.panel4, panel1, Syncfusion.Windows.Forms.Tools.DockingStyle.Tabbed, 200);

            panel1.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel4.Controls.Add(label4);

            dockingManager1.PreviewDockHints += DockingManager1_PreviewDockHints;

        }

        private void DockingManager1_PreviewDockHints(object sender, Syncfusion.Windows.Forms.Tools.PreviewDockHintsEventArgs e)
        {
            if(e.DraggingTarget == panel2 )
            {
                //Sets the panel 2 to show right dock hint for other windows to dock on right side only.
                e.DockAbility = Syncfusion.Windows.Forms.Tools.DockAbility.Right;
            }
            if(e.DraggingSource == panel1)
            {
                e.DockAbility = Syncfusion.Windows.Forms.Tools.DockAbility.Top;
            }
        }
    }
}
