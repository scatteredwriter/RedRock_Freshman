﻿using RedRock_Freshman.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;

namespace RedRock_Freshman.ViewModel
{
     public class StrategyViewModel:BasePageViewModel
    {
        private ObservableCollection<StrategyHeader> header;

        //private ruxue_page ruxue;
        public ObservableCollection<StrategyHeader> Header
        {
            get
            {
                return header;
            }

            set
            {
                header = value;
                RaisePropertyChanged(nameof(Header));
            }
        }

        //public ruxue_page Ruxue
        //{
        //    get
        //    {
        //        return ruxue;
        //    }

        //    set
        //    {
        //        ruxue = value;
        //        RaisePropertyChanged(nameof(Ruxue));
        //    }
        //}
        private string anquan;
        private string ruxue;
        private string jiangxuejin;
        private string xueshengshouce;
        public string Anquan
        {
            get
            {
                return anquan;
            }

            set
            {
                anquan = value;
                RaisePropertyChanged(nameof(Anquan));
            }
        }

        public string Ruxue
        {
            get
            {
                return ruxue;
            }

            set
            {
                ruxue = value;
                RaisePropertyChanged(nameof(Ruxue));

            }
        }

        public string Jiangxuejin
        {
            get
            {
                return jiangxuejin;
            }

            set
            {
                jiangxuejin = value;
                RaisePropertyChanged(nameof(Jiangxuejin));

            }
        }

        public string Xueshengshouce
        {
            get
            {
                return xueshengshouce;
            }

            set
            {
                xueshengshouce = value;
                RaisePropertyChanged(nameof(Xueshengshouce));
            }
        }
    }

}

