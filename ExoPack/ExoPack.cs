using Terraria.ModLoader;

namespace ExoPack
{
    class ExoPack : Mod
    {
        public ExoPack()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
    }
}