﻿using SwissAcademic.Citavi.Shell;
using System;

namespace HideKnowledgeItemTextFormHelpBox
{
    public class HideKnowledgeItemTextFormHelpBoxAddon : CitaviAddOn<KnowledgeItemTextForm>
    {
        #region Methods

        public override void OnHostingFormLoaded(KnowledgeItemTextForm knowledgeItemTextForm)
        {
            try
            {
                knowledgeItemTextForm.HelpBox.Hide();
            }
            catch (Exception){}

            base.OnHostingFormLoaded(knowledgeItemTextForm);
        }

        #endregion
    }
}