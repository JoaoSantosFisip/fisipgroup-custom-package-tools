using UnityEngine;

namespace FisipGroup.CustomPackage.Tools.Extensions
{
    /// <summary>
    /// MeshRenderer component extensions.
    /// </summary>
    public static class ExtensionsMeshRenderer
    {
        /// <summary>
        /// Sets a RenderTexture to all MeshRenderer's materials.
        /// </summary>
        /// <param name="meshRenderer"></param>
        /// <param name="textureName"></param>
        /// <param name="renderTexture"></param>
        public static void SetTextureInMaterials(this MeshRenderer meshRenderer, string textureName, RenderTexture renderTexture)
        {
            if(meshRenderer == null)
            {
                NullMeshRendererWarningMessage();

                return;
            }

            foreach (var mat in meshRenderer.materials)
            {
                mat.SetTexture(textureName, renderTexture);
            }
        }

        private static void NullMeshRendererWarningMessage()
        {
            Debug.LogWarning("FisipGroup.CustomPackage.Tools.Extensions.ExtensionsMeshRenderer: " +
                "MeshRenderer is null, returning...");
        }
    }
}