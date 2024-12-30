

using UnityEngine;

namespace GameVanilla.Editor
{
    /// <summary>
    /// The "About" tab in the editor.
    /// </summary>
    public class AboutTab : EditorTab
    {
        private const string aboutText = "HOPE YOU ENJOY THE GAME";
        private const string copyrightText =
            "I LOVE YOU";
        private const string wikiUrl = "https://wiki.gamevanilla.com";
        private const string supportUrl = "https://www.gamevanilla.com";
        private const string eulaUrl = "https://unity3d.com/legal/as_terms";
        private const string assetStoreUrl = "https://assetstore.unity.com/packages/templates/systems/puzzle-match-kit-100199";

        private readonly Texture2D logoTexture;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="editor">The parent editor.</param>
        public AboutTab(PuzzleMatchKitEditor editor) : base(editor)
        {
            logoTexture = Resources.Load<Texture2D>("EditorImages/Logo");
        }

        /// <summary>
        /// Called when this tab is drawn.
        /// </summary>
        public override void Draw()
        {
            GUILayout.Space(15);

            GUILayout.BeginVertical();
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.Label(logoTexture);
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.EndVertical();

            GUILayout.Space(15);

            var windowWidth = parentEditor.position.width;
            var centeredLabelStyle = new GUIStyle("label") {alignment = TextAnchor.MiddleCenter};
            GUI.Label(new Rect(0, 0, windowWidth, 650), aboutText, centeredLabelStyle);
            GUI.Label(new Rect(0, 0, windowWidth, 700), copyrightText, centeredLabelStyle);
            var centeredButtonStyle = new GUIStyle("button") {alignment = TextAnchor.MiddleCenter};
            if (GUI.Button(new Rect(windowWidth / 2 - 100 / 2.0f, 400, 100, 50), "Documentation", centeredButtonStyle))
            {
                Application.OpenURL(wikiUrl);
            }
            if (GUI.Button(new Rect(windowWidth / 2 - 100 / 2.0f, 460, 100, 50), "Support", centeredButtonStyle))
            {
                Application.OpenURL(supportUrl);
            }
            if (GUI.Button(new Rect(windowWidth / 2 - 100 / 2.0f, 520, 100, 50), "License", centeredButtonStyle))
            {
                Application.OpenURL(eulaUrl);
            }
            if (GUI.Button(new Rect(windowWidth / 2 - 100 / 2.0f, 580, 100, 50), "Rate me!", centeredButtonStyle))
            {
                Application.OpenURL(assetStoreUrl);
            }
        }
    }
}
