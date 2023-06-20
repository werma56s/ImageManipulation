using ImageManipulationApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulationApp.Interface
{
    interface IActionsImageAll: IActionsImage
    {
        ConvertToGray DoExtensionToGray(ConvertToGray convertToGray);
        ConvertToNegative DoExtensionToNegative(ConvertToNegative convertToNegative);
        ConvertToNegative DoExtensionResizedImage(ResizedImage resizedImage);
    }
}
