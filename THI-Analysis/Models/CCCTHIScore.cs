
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace THI_Analysis.Models
{

using System;
    using System.Collections.Generic;
    
public partial class CCCTHIScore
{

    public int ProjectKey { get; set; }

    public Nullable<int> Year { get; set; }

    public Nullable<int> Month { get; set; }

    public Nullable<double> Data_Submission_Timeliness { get; set; }

    public Nullable<double> C__Member_Support_Tickets { get; set; }

    public Nullable<double> C__Critical_Diagnostics { get; set; }

    public Nullable<double> C_Ability_to_Keep_up_w_Releases { get; set; }

    public Nullable<double> C_MineSweeper { get; set; }

    public Nullable<double> C_Data_Lag { get; set; }

    public Nullable<double> C__USE_SSA { get; set; }

    public Nullable<double> C_USE_Compass_Connect { get; set; }

    public Nullable<double> C_Data_Elements_Present { get; set; }

    public string Frequency { get; set; }

    public Nullable<double> THIScore { get; set; }

    public string ProjectPhase { get; set; }

}

}
