using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FreshFruit.model
{
    interface BucketEventListener
    {
        void onSucceed(string msg);
        void onFailed(string msg);
    }
}
