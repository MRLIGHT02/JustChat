using Microsoft.Maui.Handlers;

using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Controls
{
    class NoBorderEntry : Entry
    {

        protected override void OnHandlerChanged()
        {
            base.OnHandlerChanged();

            SetBackgroundChange();
        }

        private void SetBackgroundChange()
        {
#if ANDROID
            if (Handler is EntryHandler entryHandler)
            {

                if (BackgroundColor == null)
                {

                    entryHandler.PlatformView.BackgroundTintList = ColorStateList.
                }



            }


#endif

        }
    }
}

