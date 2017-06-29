﻿using CSharp_FlowchartToCode_DG.Options;
using System;
using System.Windows.Forms;

namespace CSharp_FlowchartToCode_DG
{
    public delegate void OperationEvent(Opt_OperationType operationType);
    public partial class OperationForm : Form
    {
        public event OperationEvent operationEvent;

        public OperationForm() => InitializeComponent();

        private void OperationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        //Build Entities
        private void button1_Click(object sender, EventArgs e) => operationEvent(Opt_OperationType.Entities);

        private void button2_Click(object sender, EventArgs e) => operationEvent(Opt_OperationType.CodeForInstance);

        private void button3_Click(object sender, EventArgs e) => operationEvent(Opt_OperationType.CodeForInstance_Another);

        private void button4_Click(object sender, EventArgs e) => operationEvent(Opt_OperationType.SqlStatements);

        //Build QX_Frame.Data
        private void button5_Click(object sender, EventArgs e) => operationEvent(Opt_OperationType.QX_Frame_Data_QueryObject);

        private void button6_Click(object sender, EventArgs e) => operationEvent(Opt_OperationType.QX_Frame_Data_Contract);

        private void button7_Click(object sender, EventArgs e) => operationEvent(Opt_OperationType.QX_Frame_Data_Service);

        //generate QX_Frame_Data_QueryObject/QX_Frame_Data_Contract/QX_Frame_Data_Service
        private void button12_Click(object sender, EventArgs e)=> operationEvent(Opt_OperationType.QX_Frame_Data_SQC);

        //Build Controller
        private void button8_Click(object sender, EventArgs e) => operationEvent(Opt_OperationType.REST_WebApiController);

        //Build Javascript
        private void button9_Click(object sender, EventArgs e) => operationEvent(Opt_OperationType.Javascript_Ajax_Data);

        private void button10_Click(object sender, EventArgs e) => operationEvent(Opt_OperationType.Javascript_Ajax_Data);

        //Build Form
        private void button11_Click(object sender, EventArgs e)
        {

        }

    }
}
