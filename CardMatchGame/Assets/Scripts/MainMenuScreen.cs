using CardMatch.Services;
using CardMatch.StateMachine.States;
using CardMatch.UI.Base;
using TMPro;
using UnityEngine;

namespace CardMatch.UI.Screens
{
    public class MainMenuScreen : ScreenBase
    {
        [SerializeField] private TextMeshProUGUI highScoreTextTmp;
        [SerializeField] private GameObject infoPanel;

        private Coroutine _titleCoroutine;

        protected internal override void EnableScreen()
        {
            base.EnableScreen();
        }

        protected internal override void DisableScreen()
        {
            base.DisableScreen();
            if (_titleCoroutine != null) StopCoroutine(_titleCoroutine);
        }

        public void PlayGame()
        {
            Bootstrap.GetService<AudioService>().PlayAudio(AudioTag.ButtonTap);
            Bootstrap.GetService<StateMachineService>().CurrentFsm.SetState(new PlayState());
        }

        public void ToggleInfoPanel(bool enable)
        {
            Bootstrap.GetService<AudioService>().PlayAudio(AudioTag.ButtonTap);
            infoPanel.SetActive(enable);
        }

        public void ExitGame()
        {
            Bootstrap.GetService<AudioService>().PlayAudio(AudioTag.ButtonTap);
            Bootstrap.GetService<StateMachineService>().CurrentFsm.SetState(new FinalState());
        }

        public override void OnBackKeyPressed() =>
            PreviousScreen(false);

    }
}