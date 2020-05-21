using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RentalROICalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Income
        public MainWindow()
        {
            InitializeComponent();
            this.SizeToContent = SizeToContent.Height;
            this.SizeToContent = SizeToContent.Width;
        }

        private void IncomeRent_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(IncomeRent.Text) && (!string.IsNullOrEmpty(IncomeMisc.Text)))
            {
                IncomeTotal.Text = Convert.ToString(Convert.ToInt32(IncomeRent.Text) + Convert.ToInt32(IncomeMisc.Text));
            }
        }

        private void IncomeMisc_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(IncomeRent.Text) && (!string.IsNullOrEmpty(IncomeMisc.Text)))
            {
                IncomeTotal.Text = Convert.ToString(Convert.ToInt32(IncomeRent.Text) + Convert.ToInt32(IncomeMisc.Text));
            }
        }

        private void IncomeTotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(IncomeRent.Text) && (!string.IsNullOrEmpty(IncomeMisc.Text)))
            {
                IncomeTotal.Text = Convert.ToString(Convert.ToInt32(IncomeRent.Text) + Convert.ToInt32(IncomeMisc.Text));
            }
        }

        //Expenses

        private void ExpensesMortgage_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(ExpensesMortgage.Text)) && (!string.IsNullOrEmpty(ExpensesTaxes.Text)) && (!string.IsNullOrEmpty(ExpensesInsurance.Text)) && (!string.IsNullOrEmpty(ExpensesHOA.Text)) && (!string.IsNullOrEmpty(ExpensesRepairs.Text)) && (!string.IsNullOrEmpty(ExpensesPropertyManager.Text)) && (!string.IsNullOrEmpty(ExpensesMisc.Text)))
            {
                ExpensesTotal.Text = Convert.ToString(Convert.ToInt32(ExpensesMortgage.Text) + Convert.ToInt32(ExpensesTaxes.Text) + Convert.ToInt32(ExpensesInsurance.Text) + Convert.ToInt32(ExpensesHOA.Text) + Convert.ToInt32(ExpensesRepairs.Text) + Convert.ToInt32(ExpensesPropertyManager.Text) + Convert.ToInt32(ExpensesMisc.Text));
            }
        }

        private void ExpensesTaxes_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(ExpensesMortgage.Text)) && (!string.IsNullOrEmpty(ExpensesTaxes.Text)) && (!string.IsNullOrEmpty(ExpensesInsurance.Text)) && (!string.IsNullOrEmpty(ExpensesHOA.Text)) && (!string.IsNullOrEmpty(ExpensesRepairs.Text)) && (!string.IsNullOrEmpty(ExpensesPropertyManager.Text)) && (!string.IsNullOrEmpty(ExpensesMisc.Text)))
            {
                ExpensesTotal.Text = Convert.ToString(Convert.ToInt32(ExpensesMortgage.Text) + Convert.ToInt32(ExpensesTaxes.Text) + Convert.ToInt32(ExpensesInsurance.Text) + Convert.ToInt32(ExpensesHOA.Text) + Convert.ToInt32(ExpensesRepairs.Text) + Convert.ToInt32(ExpensesPropertyManager.Text) + Convert.ToInt32(ExpensesMisc.Text));
            }
        }

        private void ExpensesInsurance_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(ExpensesMortgage.Text)) && (!string.IsNullOrEmpty(ExpensesTaxes.Text)) && (!string.IsNullOrEmpty(ExpensesInsurance.Text)) && (!string.IsNullOrEmpty(ExpensesHOA.Text)) && (!string.IsNullOrEmpty(ExpensesRepairs.Text)) && (!string.IsNullOrEmpty(ExpensesPropertyManager.Text)) && (!string.IsNullOrEmpty(ExpensesMisc.Text)))
            {
                ExpensesTotal.Text = Convert.ToString(Convert.ToInt32(ExpensesMortgage.Text) + Convert.ToInt32(ExpensesTaxes.Text) + Convert.ToInt32(ExpensesInsurance.Text) + Convert.ToInt32(ExpensesHOA.Text) + Convert.ToInt32(ExpensesRepairs.Text) + Convert.ToInt32(ExpensesPropertyManager.Text) + Convert.ToInt32(ExpensesMisc.Text));
            }
        }

        private void ExpensesHOA_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(ExpensesMortgage.Text)) && (!string.IsNullOrEmpty(ExpensesTaxes.Text)) && (!string.IsNullOrEmpty(ExpensesInsurance.Text)) && (!string.IsNullOrEmpty(ExpensesHOA.Text)) && (!string.IsNullOrEmpty(ExpensesRepairs.Text)) && (!string.IsNullOrEmpty(ExpensesPropertyManager.Text)) && (!string.IsNullOrEmpty(ExpensesMisc.Text)))
            {
                ExpensesTotal.Text = Convert.ToString(Convert.ToInt32(ExpensesMortgage.Text) + Convert.ToInt32(ExpensesTaxes.Text) + Convert.ToInt32(ExpensesInsurance.Text) + Convert.ToInt32(ExpensesHOA.Text) + Convert.ToInt32(ExpensesRepairs.Text) + Convert.ToInt32(ExpensesPropertyManager.Text) + Convert.ToInt32(ExpensesMisc.Text));
            }
        }

        private void ExpensesRepairs_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(ExpensesMortgage.Text)) && (!string.IsNullOrEmpty(ExpensesTaxes.Text)) && (!string.IsNullOrEmpty(ExpensesInsurance.Text)) && (!string.IsNullOrEmpty(ExpensesHOA.Text)) && (!string.IsNullOrEmpty(ExpensesRepairs.Text)) && (!string.IsNullOrEmpty(ExpensesPropertyManager.Text)) && (!string.IsNullOrEmpty(ExpensesMisc.Text)))
            {
                ExpensesTotal.Text = Convert.ToString(Convert.ToInt32(ExpensesMortgage.Text) + Convert.ToInt32(ExpensesTaxes.Text) + Convert.ToInt32(ExpensesInsurance.Text) + Convert.ToInt32(ExpensesHOA.Text) + Convert.ToInt32(ExpensesRepairs.Text) + Convert.ToInt32(ExpensesPropertyManager.Text) + Convert.ToInt32(ExpensesMisc.Text));
            }
        }

        private void ExpensesPropertyManager_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(ExpensesMortgage.Text)) && (!string.IsNullOrEmpty(ExpensesTaxes.Text)) && (!string.IsNullOrEmpty(ExpensesInsurance.Text)) && (!string.IsNullOrEmpty(ExpensesHOA.Text)) && (!string.IsNullOrEmpty(ExpensesRepairs.Text)) && (!string.IsNullOrEmpty(ExpensesPropertyManager.Text)) && (!string.IsNullOrEmpty(ExpensesMisc.Text)))
            {
                ExpensesTotal.Text = Convert.ToString(Convert.ToInt32(ExpensesMortgage.Text) + Convert.ToInt32(ExpensesTaxes.Text) + Convert.ToInt32(ExpensesInsurance.Text) + Convert.ToInt32(ExpensesHOA.Text) + Convert.ToInt32(ExpensesRepairs.Text) + Convert.ToInt32(ExpensesPropertyManager.Text) + Convert.ToInt32(ExpensesMisc.Text));
            }
        }

        private void ExpensesMisc_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(ExpensesMortgage.Text)) && (!string.IsNullOrEmpty(ExpensesTaxes.Text)) && (!string.IsNullOrEmpty(ExpensesInsurance.Text)) && (!string.IsNullOrEmpty(ExpensesHOA.Text)) && (!string.IsNullOrEmpty(ExpensesRepairs.Text)) && (!string.IsNullOrEmpty(ExpensesPropertyManager.Text)) && (!string.IsNullOrEmpty(ExpensesMisc.Text)))
            {
                ExpensesTotal.Text = Convert.ToString(Convert.ToInt32(ExpensesMortgage.Text) + Convert.ToInt32(ExpensesTaxes.Text) + Convert.ToInt32(ExpensesInsurance.Text) + Convert.ToInt32(ExpensesHOA.Text) + Convert.ToInt32(ExpensesRepairs.Text) + Convert.ToInt32(ExpensesPropertyManager.Text) + Convert.ToInt32(ExpensesMisc.Text));
            }
        }

        private void ExpensesTotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(ExpensesMortgage.Text)) && (!string.IsNullOrEmpty(ExpensesTaxes.Text)) && (!string.IsNullOrEmpty(ExpensesInsurance.Text)) && (!string.IsNullOrEmpty(ExpensesHOA.Text)) && (!string.IsNullOrEmpty(ExpensesRepairs.Text)) && (!string.IsNullOrEmpty(ExpensesPropertyManager.Text)) && (!string.IsNullOrEmpty(ExpensesMisc.Text)))
            {
                ExpensesTotal.Text = Convert.ToString(Convert.ToInt32(ExpensesMortgage.Text) + Convert.ToInt32(ExpensesTaxes.Text) + Convert.ToInt32(ExpensesInsurance.Text) + Convert.ToInt32(ExpensesHOA.Text) + Convert.ToInt32(ExpensesRepairs.Text) + Convert.ToInt32(ExpensesPropertyManager.Text) + Convert.ToInt32(ExpensesMisc.Text));
            }
        }

        //Cash Flow Section
        private void CashFlowIncome_TextChanged(object sender, TextChangedEventArgs e)
        {
            CashFlowIncome.Text = string.Copy(IncomeTotal.Text);
            CashFlowExpenses.Text = string.Copy(ExpensesTotal.Text);

            if (!string.IsNullOrEmpty(IncomeTotal.Text) && (!string.IsNullOrEmpty(ExpensesTotal.Text)))
            {
                _CashFlowTotal.Text = Convert.ToString(Convert.ToInt32(IncomeTotal.Text) - Convert.ToInt32(ExpensesTotal.Text));
            }
        }

        private void CashFlowExpenses_TextChanged(object sender, TextChangedEventArgs e)
        {
            CashFlowIncome.Text = string.Copy(IncomeTotal.Text);
            CashFlowExpenses.Text = string.Copy(ExpensesTotal.Text);

            if (!string.IsNullOrEmpty(IncomeTotal.Text) && (!string.IsNullOrEmpty(ExpensesTotal.Text)))
            {
                _CashFlowTotal.Text = Convert.ToString(Convert.ToInt32(IncomeTotal.Text) - Convert.ToInt32(ExpensesTotal.Text));
            }
        }

        private void _CashFlowTotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            CashFlowIncome.Text = string.Copy(IncomeTotal.Text);
            CashFlowExpenses.Text = string.Copy(ExpensesTotal.Text);

            if (!string.IsNullOrEmpty(IncomeTotal.Text) && (!string.IsNullOrEmpty(ExpensesTotal.Text)))
            {
                _CashFlowTotal.Text = Convert.ToString(Convert.ToInt32(IncomeTotal.Text) - Convert.ToInt32(ExpensesTotal.Text));
            }
        }

        private void CashFlowIncome_MouseEnter(object sender, MouseEventArgs e)
        {
            CashFlowIncome.Text = string.Copy(IncomeTotal.Text);
            CashFlowExpenses.Text = string.Copy(ExpensesTotal.Text);

            if (!string.IsNullOrEmpty(IncomeTotal.Text) && (!string.IsNullOrEmpty(ExpensesTotal.Text)))
            {
                _CashFlowTotal.Text = Convert.ToString(Convert.ToInt32(IncomeTotal.Text) - Convert.ToInt32(ExpensesTotal.Text));
            }
        }

        private void CashFlowExpenses_MouseEnter(object sender, MouseEventArgs e)
        {
            CashFlowIncome.Text = string.Copy(IncomeTotal.Text);
            CashFlowExpenses.Text = string.Copy(ExpensesTotal.Text);

            if (!string.IsNullOrEmpty(IncomeTotal.Text) && (!string.IsNullOrEmpty(ExpensesTotal.Text)))
            {
                _CashFlowTotal.Text = Convert.ToString(Convert.ToInt32(IncomeTotal.Text) - Convert.ToInt32(ExpensesTotal.Text));
            }
        }

        private void _CashFlowTotal_MouseEnter(object sender, MouseEventArgs e)
        {
            CashFlowIncome.Text = string.Copy(IncomeTotal.Text);
            CashFlowExpenses.Text = string.Copy(ExpensesTotal.Text);

            if (!string.IsNullOrEmpty(IncomeTotal.Text) && (!string.IsNullOrEmpty(ExpensesTotal.Text)))
            {
                _CashFlowTotal.Text = Convert.ToString(Convert.ToInt32(IncomeTotal.Text) - Convert.ToInt32(ExpensesTotal.Text));
            }
        }

        //Upfront Cost
        private void CostDownPayment_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(CostDownPayment.Text) && (!string.IsNullOrEmpty(CostClosingCost.Text) && (!string.IsNullOrEmpty(CostMiscCost.Text))))
            {
                UpfrontCostTotal.Text = Convert.ToString(Convert.ToInt32(CostDownPayment.Text) + Convert.ToInt32(CostClosingCost.Text) + Convert.ToInt32(CostMiscCost.Text));
            }
        }

        private void CostClosingCost_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(CostDownPayment.Text) && (!string.IsNullOrEmpty(CostClosingCost.Text) && (!string.IsNullOrEmpty(CostMiscCost.Text))))
            {
                UpfrontCostTotal.Text = Convert.ToString(Convert.ToInt32(CostDownPayment.Text) + Convert.ToInt32(CostClosingCost.Text) + Convert.ToInt32(CostMiscCost.Text));
            }
        }

        private void CostMiscCost_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(CostDownPayment.Text) && (!string.IsNullOrEmpty(CostClosingCost.Text) && (!string.IsNullOrEmpty(CostMiscCost.Text))))
            {
                UpfrontCostTotal.Text = Convert.ToString(Convert.ToInt32(CostDownPayment.Text) + Convert.ToInt32(CostClosingCost.Text) + Convert.ToInt32(CostMiscCost.Text));
            }
        }

        private void UpfrontCostTotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(CostDownPayment.Text) && (!string.IsNullOrEmpty(CostClosingCost.Text) && (!string.IsNullOrEmpty(CostMiscCost.Text))))
            {
                UpfrontCostTotal.Text = Convert.ToString(Convert.ToInt32(CostDownPayment.Text) + Convert.ToInt32(CostClosingCost.Text) + Convert.ToInt32(CostMiscCost.Text));
            }
        }

        //ROI
        private void _ROI_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(_CashFlowTotal.Text) && (!string.IsNullOrEmpty(UpfrontCostTotal.Text)))
            {
                _ROI.Text = Convert.ToString(((Convert.ToDecimal(_CashFlowTotal.Text)*12) / (Convert.ToDecimal(UpfrontCostTotal.Text))*100));

            }
        }

        private void _ROI_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(_CashFlowTotal.Text) && (!string.IsNullOrEmpty(UpfrontCostTotal.Text)))
            {
                _ROI.Text = Convert.ToString(((Convert.ToDecimal(_CashFlowTotal.Text) * 12) / Convert.ToDecimal(UpfrontCostTotal.Text))*100);
            }
        }

        //Clear Button
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            IncomeRent.Text = string.Empty;
            IncomeMisc.Text = string.Empty;
            IncomeTotal.Text = string.Empty;
            ExpensesMortgage.Text = string.Empty;
            ExpensesTaxes.Text = string.Empty;
            ExpensesInsurance.Text = string.Empty;
            ExpensesHOA.Text = string.Empty;
            ExpensesRepairs.Text = string.Empty;
            ExpensesPropertyManager.Text = string.Empty;
            ExpensesMisc.Text = string.Empty;
            ExpensesTotal.Text = string.Empty;
            CashFlowIncome.Text = string.Empty;
            CashFlowExpenses.Text = string.Empty;
            _CashFlowTotal.Text = string.Empty;
            CostDownPayment.Text = string.Empty;
            CostClosingCost.Text = string.Empty;
            UpfrontCostTotal.Text = string.Empty;
            CostMiscCost.Text = string.Empty;
            _ROI.Text = string.Empty;
            
        }
    }
}
  
