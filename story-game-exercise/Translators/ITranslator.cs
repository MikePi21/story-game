namespace story_game_exercise.Translators
{
    public interface ITranslator<TDbModel, TVmModel>
    {
        TVmModel Translate(TDbModel data);
    }
}

