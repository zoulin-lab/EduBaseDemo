using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class frm_NoticesAndMessages : Form
    {
        public frm_NoticesAndMessages()
        {
            InitializeComponent();
            
        }

        private void frm_NoticesAndMessages_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“eduBaseBigHomeworkDataSet.tb_NoticeAndMessage”中。您可以根据需要移动或删除它。
            this.tb_NoticeAndMessageTableAdapter.Fill(this.eduBaseBigHomeworkDataSet.tb_NoticeAndMessage);

        }
    }
}
