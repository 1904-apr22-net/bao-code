using System;
using System.Collections.Generic;
using System.Text;

//namespace matches hierarchy with '.' instead of /
namespace Shapes.Library.Interfaces
{
    //no point of putting anything private in interface
    public interface IShape
    {
        double getPerimeter();

        double Area { get; }

        int sides { get; }
    }
}
