namespace resume_model.Section;

public interface ICompositeResumeComponent : IResumeComponent
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="component"></param>
    void Add(IResumeComponent component);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="component"></param>
    void Remove(IResumeComponent component);
}