using resume_model.Section;

namespace resume_model;

public class Resume : IResumeComponent
{
    private ICompositeResumeComponent mWorkHistory;

    public ICompositeResumeComponent WorkHistory => mWorkHistory;
    
    // Private constructor as I wish to use some building pattern for this complexity.
    private Resume()
    {
        
    }
}