namespace resume_model.Section;

public class WorkHistoryEntry : IResumeComponent
{
    private string mCompanyName;
    private string mJobTitle;
    private string mJobDescription;
    private DateOnly mStartDate;
    private DateOnly mEndDate;
}