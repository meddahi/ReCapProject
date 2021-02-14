using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMyMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors =  new List<Color>()
            {
                    new Color() { ColorId = 30, ColorName = "Red" },
                    new Color() { ColorId = 40, ColorName = "Yellow" },
                    new Color() { ColorId = 50, ColorName = "Gray" },
            };

        }
        public void Add(Color entity)
        {
            _colors.Add(entity);
        }

        public void Delete(int  id)
        {
            var colorToDelete = _colors.SingleOrDefault(ctor => ctor.ColorId == id);
            _colors.Remove(colorToDelete);
            
        }

        public void Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return _colors;
        }

        public List<Color> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            var colorToUpdate = _colors.SingleOrDefault(ctor => ctor.ColorId == entity.ColorId);
            colorToUpdate.ColorName = entity.ColorName;
        }
    }
}
