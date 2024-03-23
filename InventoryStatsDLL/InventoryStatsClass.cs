/* Title:           Inventory Stats Class
 * Date:            10-411-18
 * Author:          Terry Holmes
 * 
 * Description:     This is the class that will call all Inventory Stats routines */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace InventoryStatsDLL
{
    public class InventoryStatsClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        FindInventoryIssueStatsDataSet aFindInventoryIssueStatsDataSet;
        FindInventoryIssueStatsDataSetTableAdapters.FindInventoryIssueStatsTableAdapter aFindInventoryIssueStatsTableAdapter;

        FindSpectrumInventoryIssueStatsDataSet aFindSpectrumInventoryIssueStatsDataSet;
        FindSpectrumInventoryIssueStatsDataSetTableAdapters.FindSpectrumInventoryIssueStatsTableAdapter aFindSpectrumInventoryIssueStatsTableAdapter;

        public FindSpectrumInventoryIssueStatsDataSet FindSpectrumInventoryIssueStats(int intPartID, int intWarehouseID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindSpectrumInventoryIssueStatsDataSet = new FindSpectrumInventoryIssueStatsDataSet();
                aFindSpectrumInventoryIssueStatsTableAdapter = new FindSpectrumInventoryIssueStatsDataSetTableAdapters.FindSpectrumInventoryIssueStatsTableAdapter();
                aFindSpectrumInventoryIssueStatsTableAdapter.Fill(aFindSpectrumInventoryIssueStatsDataSet.FindSpectrumInventoryIssueStats, intPartID, intWarehouseID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inventory Stats Class // Find Spectrum Inventory Issue Stats " + Ex.Message);
            }

            return aFindSpectrumInventoryIssueStatsDataSet;
        }
        public FindInventoryIssueStatsDataSet FindInventoryIssueStats(int intPartID, int intWarehouseID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindInventoryIssueStatsDataSet = new FindInventoryIssueStatsDataSet();
                aFindInventoryIssueStatsTableAdapter = new FindInventoryIssueStatsDataSetTableAdapters.FindInventoryIssueStatsTableAdapter();
                aFindInventoryIssueStatsTableAdapter.Fill(aFindInventoryIssueStatsDataSet.FindInventoryIssueStats, intPartID, intWarehouseID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Inventory Stats Class // Find Inventory Issue Stats " + Ex.Message);
            }

            return aFindInventoryIssueStatsDataSet;
        }
    }
}
