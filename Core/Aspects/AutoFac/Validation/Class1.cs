using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Intercreptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.AutoFac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        //Validatortype ver bana. Typeof() ile yaz.
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("This isn't verify class");
            }

            _validatorType = validatorType; 
        }
        //Onbeforede bu calısıcak. 
        protected override void OnBefore(IInvocation invocation)
        {
            //Calısma anında newler. 
            //Calısma tipini bul(Base typesini). CarValidatior kullandıgını dusun. Git oraya o ne ile calısıyor bak. Car ı buldu.
            //Sonrada CarValidatorun kullanılıdıgı methodun parametrelerine bak. Parametrelerde cara denk gelen parametreleri bul.
            //Bu parametrelerin herbirini gez.(Herbirinde calıs.)
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                //Buradada validation toolu merkeze aldık.
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
