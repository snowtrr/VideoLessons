using System;

namespace TextEditor
{
    using BL;

    public class MainPresenter<T>
    {
        private readonly IMainForm<T> _view;
        private readonly IFileManager<T> _manager;
        private readonly IMessgeService _messgeService;

        private T _currentFilePath;

        public MainPresenter(IMainForm<T> view, IFileManager<T> manager, IMessgeService messgeService)
        {
            _view = view;
            _manager = manager;
            _messgeService = messgeService;

            _view.SetSymbolCount(0);

            _view.ContentChanged += _view_ContentChanged;
            _view.FileOpenClick += _view_FileOpenClick;
            _view.FileSaveClick += _view_FileSaveClick;
        }

        private void _view_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                var content = _view.Content;

                _manager.SaveContent(content, _currentFilePath);

                _messgeService.ShowMessage("Файл успешно сохранен.");
            }
            catch (Exception ex)
            {
                _messgeService.ShowError(ex.Message);
            }
        }

        private void _view_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                var filePath = _view.FilePath;
                var isExist = _manager.IsExist(filePath);

                if (!isExist)
                {
                    _messgeService.ShowExclamation("Выбранный фаил не существует.");
                    return;
                }

                _currentFilePath = filePath;

                var content = _manager.GetContent(filePath);
                var count = _manager.GetSymbolCount(content);

                _view.Content = content;
                _view.SetSymbolCount(count);
            }
            catch (Exception ex)
            {
                _messgeService.ShowError(ex.Message);
            }
        }

        private void _view_ContentChanged(object sender, EventArgs e)
        {
            var content = _view.Content;

            var count = _manager.GetSymbolCount(content);

            _view.SetSymbolCount(count);
        }
    }
}