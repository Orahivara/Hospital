//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class PatientDiagnosi
    {
        public int ID { get; set; }
        public Nullable<int> IDPatient { get; set; }
        public int IDDiagnosis { get; set; }
    
        public virtual DiagnosisShitikova DiagnosisShitikova { get; set; }
        public virtual PatientShitikova PatientShitikova { get; set; }
    }
}
