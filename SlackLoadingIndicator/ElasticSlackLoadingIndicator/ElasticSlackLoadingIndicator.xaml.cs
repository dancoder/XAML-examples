using System.Windows;
using System.Windows.Media.Animation;

namespace SlackLoader
{
  /// <summary>
  /// Interaction logic for ElasticSlackLoadingIndicator.xaml
  /// </summary>
  public partial class ElasticSlackLoadingIndicator
  {
    public ElasticSlackLoadingIndicator()
    {
      InitializeComponent();

      IsVisibleChanged += SlackLoadingIndicator_IsVisibleChanged;
    }

    private void SlackLoadingIndicator_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      StartStopStoryboard(IsVisible);
    }

    private void StartStopStoryboard(bool start)
    {
      var lineAnimationStoryboard = FindResource("LineAnimationStoryboard") as Storyboard;
      if (lineAnimationStoryboard != null)
      {
        if (start)
        {
          lineAnimationStoryboard.Begin();
        }
        else
        {
          lineAnimationStoryboard.Stop();
        }
      }
    }
  }
}
