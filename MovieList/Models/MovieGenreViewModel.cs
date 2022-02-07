using Microsoft.AspNetCore.Mvc.Rendering;

namespace MovieList.Models
{
    public class MovieGenreViewModel
    {
        /// <summary>
        /// 영화 목록
        /// </summary>
        public List<Movie>? Movies { get; set; }
        /// <summary>
        /// 장르 목록
        /// </summary>
        public SelectList? Genres { get; set; }
        /// <summary>
        /// 선택한 장르가 담김
        /// </summary>
        public string? MovieGenre { get; set; }
        /// <summary>
        /// 검색 텍스트 상자에 입력한 텍스트가 담긴 SearchString
        /// </summary>
        public string? SearchString { get; set; }
    }
}
