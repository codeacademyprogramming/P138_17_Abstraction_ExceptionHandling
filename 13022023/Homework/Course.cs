using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Course:ICourse
    {
        public Group[] Groups=new Group[0];

        public void AddGroup(Group group)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;
        }

        public Group GetGroupByNo(string no)
        {
            //for (int i = 0; i < Groups.Length; i++)
            //{
            //    if (Groups[i].No == no)
            //        return Groups[i];
            //}

            foreach(Group item in Groups)
            {
                if (item.No == no)
                    return item;
            }
            return null;
        }

        public Group[] GetGroupsByPointRange(byte minPoint, byte maxPoint)
        {
            Group[] wantedGroups = new Group[0];

            foreach (var item in Groups)
            {
                if(item.AvgPoint>=minPoint && item.AvgPoint <= maxPoint)
                {
                    Array.Resize(ref wantedGroups,wantedGroups.Length + 1);
                    wantedGroups[wantedGroups.Length - 1] = item;
                }
            }

            return wantedGroups;
        }

        public Group[] Search(string search)
        {
            Group[] wantedGroups = new Group[0];

            foreach (var gr in Groups)
            {
                if(gr.No.Contains(search))
                {
                    Array.Resize(ref wantedGroups, wantedGroups.Length + 1);
                    wantedGroups[wantedGroups.Length - 1] = gr;
                }
            }
            return wantedGroups;
        }




    }
}
