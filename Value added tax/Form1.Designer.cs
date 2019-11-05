namespace Value_added_tax
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.PurchaseTime = new System.Windows.Forms.Label();
            this.Purchase = new System.Windows.Forms.Button();
            this.ListPurchase = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Label();
            this.CashBack = new System.Windows.Forms.Label();
            this.ProductsName = new System.Windows.Forms.Label();
            this.PayMethod = new System.Windows.Forms.Label();
            this.CashlessPay = new System.Windows.Forms.Label();
            this.DrinkMoney = new System.Windows.Forms.MaskedTextBox();
            this.BananaMoney = new System.Windows.Forms.MaskedTextBox();
            this.MixedMoney = new System.Windows.Forms.MaskedTextBox();
            this.price = new System.Windows.Forms.Label();
            this.SumResult = new System.Windows.Forms.Label();
            this.AppleMoney = new System.Windows.Forms.MaskedTextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.CardCheck = new System.Windows.Forms.CheckBox();
            this.EmoneyCheck = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ReducedTax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CashCheck = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PurchaseTime
            // 
            this.PurchaseTime.AutoSize = true;
            this.PurchaseTime.Location = new System.Drawing.Point(12, 131);
            this.PurchaseTime.Name = "PurchaseTime";
            this.PurchaseTime.Size = new System.Drawing.Size(53, 12);
            this.PurchaseTime.TabIndex = 0;
            this.PurchaseTime.Text = "購入時刻";
            // 
            // Purchase
            // 
            this.Purchase.Location = new System.Drawing.Point(333, 25);
            this.Purchase.Name = "Purchase";
            this.Purchase.Size = new System.Drawing.Size(103, 40);
            this.Purchase.TabIndex = 2;
            this.Purchase.Text = "購入";
            this.Purchase.UseVisualStyleBackColor = true;
            this.Purchase.Click += new System.EventHandler(this.Purchase_Click);
            // 
            // ListPurchase
            // 
            this.ListPurchase.AutoSize = true;
            this.ListPurchase.Location = new System.Drawing.Point(12, 190);
            this.ListPurchase.Name = "ListPurchase";
            this.ListPurchase.Size = new System.Drawing.Size(66, 12);
            this.ListPurchase.TabIndex = 3;
            this.ListPurchase.Text = "購入したもの";
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Location = new System.Drawing.Point(217, 133);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(29, 12);
            this.Sum.TabIndex = 4;
            this.Sum.Text = "合計";
            // 
            // CashBack
            // 
            this.CashBack.AutoSize = true;
            this.CashBack.Location = new System.Drawing.Point(217, 178);
            this.CashBack.Name = "CashBack";
            this.CashBack.Size = new System.Drawing.Size(90, 12);
            this.CashBack.TabIndex = 6;
            this.CashBack.Text = "キャッシュレス還元";
            // 
            // ProductsName
            // 
            this.ProductsName.AutoSize = true;
            this.ProductsName.Location = new System.Drawing.Point(14, 6);
            this.ProductsName.Name = "ProductsName";
            this.ProductsName.Size = new System.Drawing.Size(41, 12);
            this.ProductsName.TabIndex = 7;
            this.ProductsName.Text = "商品名";
            // 
            // PayMethod
            // 
            this.PayMethod.AutoSize = true;
            this.PayMethod.Location = new System.Drawing.Point(217, 8);
            this.PayMethod.Name = "PayMethod";
            this.PayMethod.Size = new System.Drawing.Size(63, 12);
            this.PayMethod.TabIndex = 8;
            this.PayMethod.Text = "支払い方法";
            // 
            // CashlessPay
            // 
            this.CashlessPay.AutoSize = true;
            this.CashlessPay.Location = new System.Drawing.Point(217, 244);
            this.CashlessPay.Name = "CashlessPay";
            this.CashlessPay.Size = new System.Drawing.Size(79, 12);
            this.CashlessPay.TabIndex = 10;
            this.CashlessPay.Text = "カード支払い額";
            // 
            // DrinkMoney
            // 
            this.DrinkMoney.BackColor = System.Drawing.SystemColors.Control;
            this.DrinkMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DrinkMoney.Location = new System.Drawing.Point(102, 108);
            this.DrinkMoney.Mask = "99999";
            this.DrinkMoney.Name = "DrinkMoney";
            this.DrinkMoney.Size = new System.Drawing.Size(29, 12);
            this.DrinkMoney.TabIndex = 11;
            this.DrinkMoney.Text = "0";
            this.DrinkMoney.ValidatingType = typeof(int);
            // 
            // BananaMoney
            // 
            this.BananaMoney.BackColor = System.Drawing.SystemColors.Control;
            this.BananaMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BananaMoney.Location = new System.Drawing.Point(102, 56);
            this.BananaMoney.Mask = "99999";
            this.BananaMoney.Name = "BananaMoney";
            this.BananaMoney.Size = new System.Drawing.Size(29, 12);
            this.BananaMoney.TabIndex = 12;
            this.BananaMoney.Text = "0";
            this.BananaMoney.ValidatingType = typeof(int);
            // 
            // MixedMoney
            // 
            this.MixedMoney.BackColor = System.Drawing.SystemColors.Control;
            this.MixedMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MixedMoney.Location = new System.Drawing.Point(102, 82);
            this.MixedMoney.Mask = "99999";
            this.MixedMoney.Name = "MixedMoney";
            this.MixedMoney.Size = new System.Drawing.Size(29, 12);
            this.MixedMoney.TabIndex = 13;
            this.MixedMoney.Text = "0";
            this.MixedMoney.ValidatingType = typeof(int);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(99, 8);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(29, 12);
            this.price.TabIndex = 15;
            this.price.Text = "金額";
            // 
            // SumResult
            // 
            this.SumResult.AutoSize = true;
            this.SumResult.Location = new System.Drawing.Point(219, 149);
            this.SumResult.Name = "SumResult";
            this.SumResult.Size = new System.Drawing.Size(0, 12);
            this.SumResult.TabIndex = 16;
            // 
            // AppleMoney
            // 
            this.AppleMoney.BackColor = System.Drawing.SystemColors.Control;
            this.AppleMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppleMoney.Location = new System.Drawing.Point(102, 29);
            this.AppleMoney.Mask = "99999";
            this.AppleMoney.Name = "AppleMoney";
            this.AppleMoney.Size = new System.Drawing.Size(29, 12);
            this.AppleMoney.TabIndex = 14;
            this.AppleMoney.Text = "0";
            this.AppleMoney.ValidatingType = typeof(int);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(23, 155);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(0, 12);
            this.DateLabel.TabIndex = 17;
            // 
            // CardCheck
            // 
            this.CardCheck.AutoSize = true;
            this.CardCheck.Location = new System.Drawing.Point(219, 71);
            this.CardCheck.Name = "CardCheck";
            this.CardCheck.Size = new System.Drawing.Size(94, 16);
            this.CardCheck.TabIndex = 23;
            this.CardCheck.Text = "クレジットカード";
            this.CardCheck.UseVisualStyleBackColor = true;
            // 
            // EmoneyCheck
            // 
            this.EmoneyCheck.AutoSize = true;
            this.EmoneyCheck.Location = new System.Drawing.Point(219, 93);
            this.EmoneyCheck.Name = "EmoneyCheck";
            this.EmoneyCheck.Size = new System.Drawing.Size(77, 16);
            this.EmoneyCheck.TabIndex = 24;
            this.EmoneyCheck.Text = "電子マネー";
            this.EmoneyCheck.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 19);
            this.textBox1.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 19);
            this.textBox3.TabIndex = 27;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(14, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(66, 19);
            this.textBox4.TabIndex = 28;
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.Location = new System.Drawing.Point(157, 27);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(15, 14);
            this.checkBox0.TabIndex = 29;
            this.checkBox0.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(157, 54);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(157, 82);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // ReducedTax
            // 
            this.ReducedTax.AutoSize = true;
            this.ReducedTax.Location = new System.Drawing.Point(142, 7);
            this.ReducedTax.Name = "ReducedTax";
            this.ReducedTax.Size = new System.Drawing.Size(53, 12);
            this.ReducedTax.TabIndex = 33;
            this.ReducedTax.Text = "軽減税率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 39;
            // 
            // CashCheck
            // 
            this.CashCheck.AutoSize = true;
            this.CashCheck.Location = new System.Drawing.Point(219, 49);
            this.CashCheck.Name = "CashCheck";
            this.CashCheck.Size = new System.Drawing.Size(48, 16);
            this.CashCheck.TabIndex = 22;
            this.CashCheck.Text = "現金";
            this.CashCheck.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(157, 109);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 40;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 19);
            this.textBox2.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 306);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReducedTax);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox0);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EmoneyCheck);
            this.Controls.Add(this.CardCheck);
            this.Controls.Add(this.CashCheck);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SumResult);
            this.Controls.Add(this.price);
            this.Controls.Add(this.AppleMoney);
            this.Controls.Add(this.MixedMoney);
            this.Controls.Add(this.BananaMoney);
            this.Controls.Add(this.DrinkMoney);
            this.Controls.Add(this.CashlessPay);
            this.Controls.Add(this.PayMethod);
            this.Controls.Add(this.ProductsName);
            this.Controls.Add(this.CashBack);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.ListPurchase);
            this.Controls.Add(this.Purchase);
            this.Controls.Add(this.PurchaseTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PurchaseTime;
        private System.Windows.Forms.Button Purchase;
        private System.Windows.Forms.Label ListPurchase;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label CashBack;
        private System.Windows.Forms.Label ProductsName;
        private System.Windows.Forms.Label PayMethod;
        private System.Windows.Forms.Label CashlessPay;
        private System.Windows.Forms.MaskedTextBox DrinkMoney;
        private System.Windows.Forms.MaskedTextBox BananaMoney;
        private System.Windows.Forms.MaskedTextBox MixedMoney;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label SumResult;
        private System.Windows.Forms.MaskedTextBox AppleMoney;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.CheckBox CardCheck;
        private System.Windows.Forms.CheckBox EmoneyCheck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox0;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label ReducedTax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CashCheck;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

