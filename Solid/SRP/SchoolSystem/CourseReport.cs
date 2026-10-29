
using System.Collections.Generic;
using System.Text.Json;

namespace DesignPatternsAndSOLIDPrinciples.Solid.SRP.SchoolSystem;

public class CourseReport
{
    private readonly List<CourseReportEntry> _entries;

    public CourseReport()
    {
        _entries = new List<CourseReportEntry>();
    }

    public void AddEntry(CourseReportEntry entry)=> _entries.Add( entry );
    public void RemoveEntry(int index)=> _entries.RemoveAt( index );
    public override string ToString()
    {
        return JsonSerializer.Serialize( _entries );
    }

}