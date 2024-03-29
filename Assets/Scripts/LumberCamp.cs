namespace Scripts
{
    public class LumberCamp : Buildings
    {
        #region Public

        #endregion

        #region Private

        #endregion

        #region Unity

        private void Awake()
        {
            _buildingPrice = 100;
            _buildingPriceText.text = _buildingPrice.ToString() + " Meat";
        }

        #endregion

        #region Methods

        public override void BuildingUpgrade()
        {
            if (_resourcesManager.ResourcesStock["Meat"] >= _buildingPrice)
            {
                base.BuildingUpgrade();
                _resourcesManager.RemoveInStock("Meat", _buildingPrice);

                _buildingPrice *= 2;
                _buildingPriceText.text = _buildingPrice.ToString() + " Meat";
            }
        }

        protected override void MeatGeneration()
        {
            base.MeatGeneration();
            _resourcesManager.AddInStock("Wood", _buildingLevel * 2);
        }

        #endregion

        #region Utils

        #endregion

        #region Getter & Setters

        #endregion
    }
}
